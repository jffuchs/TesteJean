using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AcessoDados
{
    public class Conexao
    {
        SqlConnection conn = new SqlConnection();

        public Conexao()
        {
            conn.ConnectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=TesteJean;Integrated Security=True";
        }
        
        public SqlConnection Conectar()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;            
        }

        public void Desconectar()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
