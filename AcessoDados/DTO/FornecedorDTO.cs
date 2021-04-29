using System;

namespace AcessoDados.DTO
{
    public class FornecedorDTO
    {
        public enum TipoPessoaEnum
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
        public string RG { get; set; }
        public DateTime DataNascimento { get; set; }

        public string CPFCNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public TipoPessoaEnum Pessoa
        {
            get
            {
                if (cnpj.Length == 11)
                {
                    return TipoPessoaEnum.Fisica;
                }
                else
                {
                    return TipoPessoaEnum.Juridica;
                }
                ;
            }
        }
    }
}
