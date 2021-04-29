using System;
using System.Text;
using System.Text.RegularExpressions;

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

        public static string FormatarCPFCNPJ(string CPFCNPJ)
        {
            string aux = Util.RetornarApenasNumeros(CPFCNPJ);
            try
            {
                if (aux.Length == 11)
                {
                    return Convert.ToUInt64(aux).ToString(@"000\.000\.000\-00");
                }
                else
                {
                    return Convert.ToUInt64(aux).ToString(@"00\.000\.000\/0000\-00");
                }
            }
            catch (Exception)
            {
                return CPFCNPJ;
            }
        }

        public static string RetornarApenasNumeros(string str)
        {
            var result = new StringBuilder(str.Length);
            foreach (var letra in str)
            {
                if (Char.IsDigit(letra))
                {
                    result.Append(letra);
                }
            }
            return result.ToString();
        }

        public static string FormatarTelefone(string fone)
        {
            string strMascara = "{0:(00)0000-0000}";
            try
            {
                long lngNumero = Convert.ToInt64(RetornarApenasNumeros(fone));
                if (fone.Length == 11)
                {
                    strMascara = "{0:(00)00000-0000}";
                }
                return string.Format(strMascara, lngNumero);
            }
            catch (Exception)
            {
                return fone;
            }
        }
    }
}
