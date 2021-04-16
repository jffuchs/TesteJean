using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AcessoDados
{
    static class DataAccess
    {
        /// procura nos atributos do tipo ex: typeof(Pessoa)
        /// um atributo do tipo "TabelaAtributo"
        /// retorna o nome da tabela se achar     
        private static string GetTabela(Type tipo)
        {
            // usa reflection para extrair os "Custom" atributes
            Attribute[] atributos = Attribute.GetCustomAttributes(tipo);
            // percorre todos atributos
            foreach (Attribute atributo in atributos)
            {
                // achou atributo tabela? é esse!
                if (atributo is TabelaAttribute)
                {
                    // retorna no nome
                    TabelaAttribute tabela = (TabelaAttribute)atributo;
                    return tabela.Nome;
                }
            }
            return "";
        }

        /// método que recebe um tipo
        /// pega os membros desse tipo e lê atributos custom
        /// para retornar o nome do campo (retorna num list de campo)        
        private static List<Campo> GetCampos(Type tipo)
        {
            List<Campo> retorno = new List<Campo>();
            // reflection que pega os membros de um tipo
            MemberInfo[] members = tipo.GetMembers();
            // pra cada membro...
            foreach (MemberInfo member in members)
            {
                // pega os atributos dos membros e joga num object[]
                object[] attributes = member.GetCustomAttributes(true);
                // se o membro for do tipo Property (pode ser Method, Public,)
                if (member.MemberType == MemberTypes.Property)
                {
                    // tem atributos?
                    if (attributes.Length != 0)
                    {
                        // percorre os atributos
                        foreach (object attribute in attributes)
                        {
                            // se o atributo for CampoAttribute...
                            if (attribute is CampoAttribute)
                            {
                                CampoAttribute da = (CampoAttribute)attribute;
                                // adiciona numa list um "Campo" que contém nome da propriedade e do campo
                                Campo campo = new Campo()
                                {
                                    Chave = da.Chave,
                                    Nome = da.Nome,                                    
                                    Propriedade = member.Name.ToString()
                                };
                                retorno.Add(campo);
                            }
                        }
                    }
                }
            }
            return retorno;
        }

        // este método aceita como parâmetro Generics
        // ele pega as propriedades do objeto t e as percorre
        // pra cada propriedade, ele procura na list passada como parâmetro
        // um campo com mesma "Propriedade" (que é o nome do campo)
        // se achou, adiciona o valor na propria list que é ref e cai fora
        private static void GetPropriedades<T>(T t, ref List<Campo> lista)
        {
            Type tipo = typeof(T);

            // pega as propriedades e os valores do objeto
            var properties = tipo.GetProperties();

            // percorre as propriedades
            foreach (PropertyInfo property in properties)
            {
                // pra cada propriedade, procura o equivalente no "lista"
                // que já contem o nome e tipo do campo
                for (int i = 0; i < lista.Count; i++)
                {
                    // encontrou com mesmo nome?
                    if (lista[i].Propriedade.Equals(property.Name))
                    {
                        lista[i].Valor = property.GetValue(t, null).ToString();
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Função retorna uma string já montadinha de update com os campos e nome
        /// da tabela com base no custom attributes feitos no objeto "t"
        /// </summary>
        /// <typeparam name="T">Classe do modelo</typeparam>
        /// <param name="t">Objeto (pessoa, cliente, etc)</param>
        /// <param name="tipo">typeof(t)</param>
        /// <returns>um string com update já levando em conta as chaves</returns>
        public static string MontarUpdate<T>(T t, Type tipo)
        {
            // o GetCampos retorna usando reflection o nome dos campos
            List<Campo> campos = GetCampos(tipo);

            // GetPropriedades completa a list campos com o valor dos campos
            GetPropriedades(t, ref campos);

            StringBuilder chavestr = new StringBuilder();
            StringBuilder campostr = new StringBuilder();

            // percorre os campos chaves e normais
            foreach (Campo campo in campos)
            {                
                if (campo.Chave)
                    chavestr.Append(campo.Nome + "=" + campo.Valor + " and ");
                else
                    campostr.Append(campo.Nome + "=" + campo.Valor + ",");
            }

            // remove lixo no final
            chavestr.Remove(chavestr.Length - 5, 5);
            campostr.Remove(campostr.Length - 1, 1);

            // monta update de saída
            return "update " + GetTabela(tipo) +
                   " set " + campostr.ToString() +
                   " where " + chavestr.ToString();
        }

        /// <summary>
        /// Função retorna uma string já montadinha de insert com os campos e nome
        /// da tabela com base no custom attributes feitos no objeto "t"
        /// </summary>
        /// <typeparam name="T">Classe do modelo</typeparam>
        /// <param name="t">Objeto (pessoa, cliente, etc)</param>
        /// <param name="tipo">typeof(t)</param>
        /// <returns>um string com insert já levando em conta as chaves</returns>
        public static string MontarInsert<T>(T t, Type tipo)
        {
            // o GetCampos retorna usando reflection o nome dos campos
            List<Campo> campos = GetCampos(tipo);

            // GetPropriedades completa a list campos com o valor dos campos
            GetPropriedades(t, ref campos);

            StringBuilder valuesstr = new StringBuilder();
            StringBuilder campostr = new StringBuilder();

            // percorre os campos e valores
            foreach (Campo campo in campos)
            {
                if (!campo.Chave)
                {
                    campostr.Append(campo.Nome + ",");
                    valuesstr.Append(campo.Valor + ",");
                }                
            }
            // remove lixo no final
            valuesstr.Remove(valuesstr.Length - 1, 1);
            campostr.Remove(campostr.Length - 1, 1);

            // monta insert de saída
            return "insert into " + GetTabela(tipo) +
                   " (" + campostr.ToString() +
                   ") values (" + valuesstr.ToString() + ")";
        }
    }
}
