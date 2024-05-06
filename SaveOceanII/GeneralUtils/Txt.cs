using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveOceanII.GeneralUtils
{
    public class Txt
    {
        /// <summary>
        /// Mètode centra el text
        /// </summary>
        /// <param name="content">el text a centrar </param>
        /// <param name="maxLength">el espai que té </param>
        /// <returns>retorna el contigut ajustat al centre del espai assignat, si l contigut és major que l'espai no es mostrarà de forma correcta</returns>
        public static string Format(string content, int maxLength)
        {
            char[] aux = new char[maxLength];
            int startAt = maxLength - content.Length > 0 ? (maxLength - content.Length) / 2 : 0;
            for (int i = 0, j = 0; i < maxLength; i++)
            {
                if (i == startAt)
                {
                    aux[i] = j < content.Length ? content[j] : ' ';
                    startAt++;
                    j++;
                }
                else
                {
                    aux[i] = ' ';
                }
            }
            string result = new string(aux);
            return result;
        }

        /// <summary>
        /// Mètode per cambiar la primera lletra en mayuscula
        /// </summary>
        /// <param name="name">rep qualsevol string, preferible noms propis </param>
        /// <returns>retorna un nom propi escrit correctament</returns>
        public static string Name(string name)
        {
            string uppercaseName = name[0].ToString().ToUpper() + name[1..];
            return uppercaseName;
        }
    }
}
