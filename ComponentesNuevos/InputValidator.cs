using System.Drawing;
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ComponentesPersonalizados
{
    public class InputValidator
    {
        public static bool EsSoloNumeros(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool EsSoloLetras(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}