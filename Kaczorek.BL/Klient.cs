using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaczorek.BL
{
    public class Klient
    {
        private string _nazwisko;
        public string Nazwisko
        {
            get
            {
                //Tutaj mogę dodać dowolny kod
                return _nazwisko;
            }
            set
            {
                //Tutaj mogę dodać dowolny kod
                _nazwisko = value;
            }
        }

        public string Imie { get; set; }

        public string Email { get; set; }

        public int KlientId { get; private set; }

        public string ImieNazwisko
        {
            get
            {
                string imieNazwisko = Imie;

                if (!string.IsNullOrWhiteSpace(Nazwisko))
                {
                    if (!string.IsNullOrWhiteSpace(imieNazwisko))
                    {
                        imieNazwisko += ", ";
                    }
                    imieNazwisko += Nazwisko;
                }
                return imieNazwisko;
            }
        }

    }
}
