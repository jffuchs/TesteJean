using System;
using System.Data.SQLite;
using System.Text;

namespace AcessoDados
{
    public class Empresa : AcessoBD
    {
        SQLiteCommand cmd = new SQLiteCommand();

        public Empresa()
        {
            NomeTabela = "EMPRESA";
        }

        public void IncluirAlterar(DTO.EmpresaDTO dados)
        {
            StringBuilder str = new StringBuilder();

            if (dados.ID <= 0)
            {
                str.AppendLine("INSERT INTO Empresa (EMP_NOME, EMP_CNPJ, IDF_UF)");
                str.AppendLine("VALUES (@nome, @cnpj, @IDF_UF)");
            }
            else
            {
                str.AppendLine("UPDATE Empresa SET EMP_NOME = @nome, EMP_CNPJ = @cnpj, IDF_UF = @IDF_UF");
                str.AppendLine("WHERE ID_EMPRESA = " + dados.ID);
            }
            cmd.CommandText = str.ToString();

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nome", dados.Nome);
            cmd.Parameters.AddWithValue("@cnpj", dados.CNPJ);
            cmd.Parameters.AddWithValue("@IDF_UF", dados.IDF_UF);
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (SQLiteException ex)
            {
                throw new Exception("Erro ao incluir/alterar empresa.\n" + ex.Message);
            }
        }

        public DTO.EmpresaDTO Dados(int idEmpresa)
        {
            DTO.EmpresaDTO aux = new DTO.EmpresaDTO();

            dadosTabela = RetornarDataTable(String.Format("SELECT * FROM EMPRESA WHERE ID_EMPRESA = {0}", idEmpresa));
            if (dadosTabela.Rows.Count > 0)
            {
                aux.ID = idEmpresa;
                aux.Nome = dadosTabela.Rows[0]["EMP_NOME"].ToString();
                aux.CNPJ = dadosTabela.Rows[0]["EMP_CNPJ"].ToString();
                aux.IDF_UF = Convert.ToInt32(dadosTabela.Rows[0]["IDF_UF"].ToString());
            }
            return aux;
        }
    }
}
