using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class RegraUF : RegraNegocioBase
{
        AcessoDados.UF acessoUF = new AcessoDados.UF();

        public DataTable CarregarRegistros()
        {
            return acessoUF.RetornarDataTable("SELECT * FROM UF ORDER BY UF_NOME");
        }

        public AcessoDados.DTO.UFDTO Dados(int idf_uf)
        {
            return acessoUF.Dados(idf_uf);
        }
    }
}
