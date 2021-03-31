﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.DTO
{
    public class EmpresaDTO
    {
        public string NomeTabela = "EMPRESA";
        public string NomeCampoID = "ID_EMPRESA";
        
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public int IDF_UF { get; set; }
    }
}
