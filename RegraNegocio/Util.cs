using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class Util
    {
        public static int CalcularIdade(DateTime dataNascimento)
        {
            DateTime hoje = DateTime.Today;
            int idade = hoje.Year - dataNascimento.Year;
            if (dataNascimento > hoje.AddYears(-idade))
            {
                idade--;
            }
            return idade;
        }
    }
}
