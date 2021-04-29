using System.Data.SQLite;

namespace AcessoDados
{
    public class Conexao
    {
        private readonly SQLiteConnection minhaConexao = new SQLiteConnection();

        public Conexao()
        {
            minhaConexao.ConnectionString = @"URI=file:C:\TesteJean\Data\TesteJean.db";
        }

        public SQLiteConnection Conectar()
        {
            if (minhaConexao.State == System.Data.ConnectionState.Closed)
            {
                minhaConexao.Open();
            }
            return minhaConexao;
        }

        public void Desconectar()
        {
            if (minhaConexao.State == System.Data.ConnectionState.Open)
            {
                minhaConexao.Close();
            }
        }
    }
}
