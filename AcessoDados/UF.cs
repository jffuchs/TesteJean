using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class UF : AcessoBD
    {
        public DTO.UFDTO Dados(int idf_uf)
        {
            DTO.UFDTO aux = new DTO.UFDTO();

            DataTable tabela = new DataTable();
            tabela = RetornarDataTable(String.Format("SELECT * FROM UF WHERE ID_UF = {0}", idf_uf));
            if (tabela.Rows.Count > 0)
            {
                aux.ID = idf_uf;
                aux.Sigla = tabela.Rows[0]["UF_SIGLA"].ToString();
                aux.Nome = tabela.Rows[0]["UF_NOME"].ToString();                
            }
            return aux;
        }
    }
}
