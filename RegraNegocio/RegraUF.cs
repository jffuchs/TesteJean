﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class RegraUF
    {
        AcessoDados.UF acessoUF = new AcessoDados.UF();

        public DataTable RetornarListaUF()
        {
            return acessoUF.RetornarDataTable("SELECT * FROM UF ORDER BY UF_NOME");
        }

        public AcessoDados.DTO.UFDTO RetornarUF(int idf_uf)
        {
            return acessoUF.RetornarUF(idf_uf);
        }
    }
}