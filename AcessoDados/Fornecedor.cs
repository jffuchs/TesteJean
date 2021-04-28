using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class Fornecedor : AcessoBD
    {
        SQLiteCommand cmd = new SQLiteCommand();

        public Fornecedor()
        {
            NomeTabela = "FORNECEDOR";
        }

        public void IncluirAlterar(DTO.FornecedorDTO dados)
        {
            StringBuilder str = new StringBuilder();

            if (dados.ID <= 0)
            {
                str.AppendLine("INSERT INTO Fornecedor (FOR_NOME, FOR_CPFCNPJ, FOR_TELEFONE, IDF_EMPRESA, FOR_DTHRCAD, FOR_RG, FOR_DTNASC)");
                str.AppendLine("VALUES (@nome, @cnpj, @fone, @IDF_EMPRESA, @dtHrCad, @RG, @dtnasc)");                
            }
            else
            {
                str.AppendLine("UPDATE Fornecedor SET FOR_NOME = @nome, FOR_CPFCNPJ = @cnpj, FOR_TELEFONE = @fone, IDF_EMPRESA = @IDF_EMPRESA, FOR_RG = @RG, FOR_DTNASC = @dtnasc");
                str.AppendLine("WHERE ID_FORNECEDOR = " + dados.ID);
            }
            cmd.CommandText = str.ToString();

            cmd.Parameters.Clear();
            if (dados.ID <= 0)
            {
                cmd.Parameters.AddWithValue("@dtHrCad", DateTime.Now.ToString("dd/MM/yyyy"));
            }                
            cmd.Parameters.AddWithValue("@nome", dados.Nome);
            cmd.Parameters.AddWithValue("@cnpj", dados.CPFCNPJ);
            cmd.Parameters.AddWithValue("@fone", dados.Telefone);
            cmd.Parameters.AddWithValue("@RG", dados.RG);
            cmd.Parameters.AddWithValue("@dtnasc", dados.DataNascimento.ToString("dd/MM/yyyy"));
            cmd.Parameters.AddWithValue("@IDF_EMPRESA", dados.IDF_EMPRESA);
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (SQLiteException ex)
            {
                throw new Exception("Erro ao incluir/alterar fornecedor.\n" + ex.Message);
            }
        }

        public DTO.FornecedorDTO Dados(int idFornecedor)
        {
            DTO.FornecedorDTO aux = new DTO.FornecedorDTO();

            dadosTabela = RetornarDataTable(String.Format("SELECT * FROM FORNECEDOR WHERE ID_FORNECEDOR = {0}", idFornecedor));
            if (dadosTabela.Rows.Count > 0)
            {
                aux.ID = idFornecedor;
                aux.Nome = dadosTabela.Rows[0]["FOR_NOME"].ToString();
                aux.CPFCNPJ = dadosTabela.Rows[0]["FOR_CPFCNPJ"].ToString();
                aux.Telefone = dadosTabela.Rows[0]["FOR_TELEFONE"].ToString();
                aux.IDF_EMPRESA = Convert.ToInt32(dadosTabela.Rows[0]["IDF_EMPRESA"].ToString());
                aux.RG = dadosTabela.Rows[0]["FOR_RG"].ToString();
                aux.DataNascimento = DateTime.Parse(dadosTabela.Rows[0]["FOR_DTNASC"].ToString());
            }
            return aux;
        }

        public DTO.FornecedorDTO Dados(string CPFCNPJ)
        {
            DTO.FornecedorDTO aux = new DTO.FornecedorDTO();

            dadosTabela = RetornarDataTable(String.Format("SELECT * FROM FORNECEDOR WHERE FOR_CPFCNPJ = '{0}'", CPFCNPJ));
            if (dadosTabela.Rows.Count > 0)
            {
                aux.ID = Convert.ToInt32(dadosTabela.Rows[0]["ID_FORNECEDOR"].ToString());
                aux.Nome = dadosTabela.Rows[0]["FOR_NOME"].ToString();
                aux.CPFCNPJ = CPFCNPJ;
                aux.Telefone = dadosTabela.Rows[0]["FOR_TELEFONE"].ToString();
                aux.IDF_EMPRESA = Convert.ToInt32(dadosTabela.Rows[0]["IDF_EMPRESA"].ToString());
                aux.RG = dadosTabela.Rows[0]["FOR_RG"].ToString();
                aux.DataNascimento = DateTime.Parse(dadosTabela.Rows[0]["FOR_DTNASC"].ToString());
            }
            return aux;
        }
    }
}