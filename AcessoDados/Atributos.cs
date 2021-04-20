using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    class Atributos
    {
    }

    public enum TipoCampo
    {
        Texto,
        Inteiro,
        DataHora,
        Monetario
    }

    public class TabelaAttribute : Attribute
    {
        public TabelaAttribute(string nome)
        {
            this.Nome = nome;
        }
        public string Nome { get; set; }
    }

    public class CampoAttribute : Attribute
    {
        public CampoAttribute(string nome)
        {
            this.Nome = nome;
        }
        public string Nome { get; set; }
        public bool Chave { get; set; }

        [DefaultValue(TipoCampo.Inteiro)] 
        public TipoCampo Tipo { get; set; }
    }
}
