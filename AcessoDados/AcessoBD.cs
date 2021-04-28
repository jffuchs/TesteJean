using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class AcessoBD
    {
        protected Conexao conexao;
        private StringBuilder strSQL;
        private SQLiteCommand comandoSql;
        protected DataTable dadosTabela;        
        protected string nomeTabela = "";
        protected string nomeCampoID = "";

        public string NomeTabela
        {
            get { return nomeTabela; }
            set
            {
                nomeTabela = value;
                nomeCampoID = "ID_" + value;
            }
        }

        public AcessoBD()
        {
            conexao = new Conexao();
            strSQL = new StringBuilder();
            comandoSql = new SQLiteCommand();
            dadosTabela = new DataTable();
        }

        public bool ExcluirRegistro(int idTabela)
        {
            try
            {
                comandoSql.CommandText = String.Format("DELETE FROM {0} WHERE {1} = {2}", nomeTabela, nomeCampoID, idTabela);
                comandoSql.Connection = conexao.Conectar();
                bool ok = comandoSql.ExecuteNonQuery() > 0;
                conexao.Desconectar();
                return ok;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir o registro.\n" + ex.Message);
            }
        }

        public DataTable RetornarDataTable(string strComando)
        {         
            var sqlAdapter = new SQLiteDataAdapter(strComando, conexao.Conectar());

            DataTable tabela = new DataTable();
            sqlAdapter.AcceptChangesDuringFill = false;
            sqlAdapter.Fill(tabela);

            return tabela;
        }
    }
}
