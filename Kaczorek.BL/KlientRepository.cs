using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaczorek.BL
{
    public class KlientRepository
    {
        

        /// <summary>
        /// Pobieramy jednego wskazanego klienta
        /// </summary>
        /// <param name="KlientId"></param>
        /// <returns></returns>
        public Klient Pobierz(int klientId)
        {
            //Tworzymy nową instacncje klienta
            Klient klient = new Klient(klientId);
            // kod, który pobiera określonego klienta
            //tymczasowo zakodowane wartości aby zwrócić klienta
            if (klientId == 1)
            {
                klient.Email = "m.buczynski93@gmail.com";
                klient.Imie = "Marcin";
                klient.Nazwisko = "Buczyński";
            }

            return klient;
        }
            /// <summary>
            /// Pobiera wszystkich klientów
            /// </summary>
            /// <returns></returns>
            public List<Klient> Pobierz()
            {
                // kod, który pobiera wszystkich klientów
                return new List<Klient>();
            }

        /// <summary>
        /// Zapisuje klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // kod który zapisuje zdefiniowanego klienta
            return true;
        }
    }
    }

