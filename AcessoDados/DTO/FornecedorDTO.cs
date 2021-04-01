using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.DTO
{
    public class FornecedorDTO
    {
        public enum TipoPessoa
        {
            Fisica,
            Juridica
        }

        public string NomeTabela = "FORNECEDOR";
        public string NomeCampoID = "ID_FORNECEDOR";

        private string cnpj;

        public int ID { get; set; }
        public int IDF_EMPRESA { get; set; }
        public string Nome { get; set; }
        public DateTime DataHoraCadastro { get; set; }
        public string Telefone { get; set; }
        
        public string CPFCNPJ 
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        
        public TipoPessoa Pessoa 
        { 
            get 
            {
                if (cnpj.Length == 11)
                {
                    return TipoPessoa.Fisica;
                }
                else
                {
                    return TipoPessoa.Juridica;
                }
                ;
            } 
        }
    }
}
