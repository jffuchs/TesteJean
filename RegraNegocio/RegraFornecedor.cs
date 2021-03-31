using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class RegraFornecedor
    {
        AcessoDados.Fornecedor acessoFornecedor = new AcessoDados.Fornecedor();

        public void IncluirAlterar(AcessoDados.DTO.FornecedorDTO dados)
        {
            RegraEmpresa empresa = new RegraEmpresa();
            RegraUF UF = new RegraUF();

            if (dados.Pessoa == AcessoDados.DTO.FornecedorDTO.TipoPessoa.Fisica)
            {
                if (UF.RetornarUF(empresa.RetornarEmpresa(dados.IDF_EMPRESA).IDF_UF).Sigla == "PR")
                {
                    if (Util.CalcularIdade(dados.DataHoraCadastro) < 18)
                    {
                        throw new Exception("Fornecedor Pessoa Física deve ser maior de idade!");
                    }                     
                }
            }            

            try
            {
                acessoFornecedor.IncluirAlterar(dados);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(int idFornecedor)
        {
            try
            {
                acessoFornecedor.ExcluirRegistro(idFornecedor);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable CarregarRegistros()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("SELECT ID_FORNECEDOR, FOR_NOME, FOR_CPFCNPJ, FOR_TELEFONE, FOR_DTHRCAD FROM FORNECEDOR");
            //str.AppendLine("LEFT JOIN UF ON ID_UF = IDF_UF");
            return acessoFornecedor.RetornarDataTable(str.ToString());
        }

        public AcessoDados.DTO.FornecedorDTO DadosFornecedor(int idFornecedor)
        {
            return acessoFornecedor.Dados(idFornecedor);
        }
    }
}
