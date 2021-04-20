using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.DTO
{
    [Tabela("EMPRESA")]
    public class EmpresaDTO
    {
        public string NomeTabela = "EMPRESA";
        public string NomeCampoID = "ID_EMPRESA";

        [Campo("ID_EMPRESA", Chave = true)] 
        public int ID { get; set; }
        
        [Campo("EMP_NOME", Tipo = TipoCampo.Texto)] 
        public string Nome { get; set; }

        [Campo("EMP_CNPJ", Tipo = TipoCampo.Texto)] 
        public string CNPJ { get; set; }

        [Campo("IDF_UF")]
        public int IDF_UF { get; set; }
    }
}
