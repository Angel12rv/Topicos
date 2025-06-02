using System.Drawing;
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ComponentesPersonalizados
{
    public class RFCValidator
    {
        public static bool EsRFCValido(string rfc)
        {
            string pattern = @"^[A-Z]{4}\d{6}[A-Z0-9]{2,3}$";
            return Regex.IsMatch(rfc, pattern);
        }

        public static string CorregirRFC(string rfc)
        {
            rfc = rfc.ToUpper().Trim();
            return rfc;
        }
    }
}