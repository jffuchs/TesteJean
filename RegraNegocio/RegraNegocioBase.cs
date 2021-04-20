using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class RegraNegocioBase
    {
        public string NomeCampoID = "";

        public virtual void Excluir(int idTabela)
        {
        }

        public virtual DataTable CarregarRegistros(string filtros = "")
        {
            return null;
        }

        public virtual DataTable CarregarRegistrosFiltrados(string nomeCampo, string valorCampo, string tipoCampo)
        {
            try
            {
                if (tipoCampo == "DateTime")
                {
                    if (Util.ValidarData(valorCampo))
                    {
                        return CarregarRegistros(string.Format("{0} = '{1}'", nomeCampo, valorCampo));
                    }
                    else
                    {
                        return CarregarRegistros();
                    }
                }
                else
                {
                    return CarregarRegistros(string.Format("{0} LIKE '{1}%'", nomeCampo, valorCampo));
                }
            }
            catch (Exception)
            {
                return CarregarRegistros();
            }
        }
    }
}
