using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace AcessoDados
{
    public class Conexao
    {
        SQLiteConnection conn = new SQLiteConnection();

        public Conexao()
        {
            conn.ConnectionString = @"URI=file:C:\TesteJean\Data\TesteJean.db";            
        }
        
        public SQLiteConnection Conectar()
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
