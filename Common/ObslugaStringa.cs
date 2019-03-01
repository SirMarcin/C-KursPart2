using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ObslugaStringa
    {
        public string WstawSpacje(string zrodlo)
        {
            string wynik = string.Empty;

            if (!String.IsNullOrWhiteSpace(zrodlo))
            {
                foreach (var litera in zrodlo)
                {
                    if (char.IsUpper(litera))
                    {
                        wynik = wynik.Trim();
                        wynik += " ";
                    }
                    wynik += litera;
                }
                wynik = wynik.Trim();
            }
            return wynik;
        }
    }
}
