using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public static bool ValidarData(string data)
        {
            Regex r = new Regex(@"(\d{2}\/\d{2}\/\d{4})");
            return r.Match(data).Success;
        }
    }
}
