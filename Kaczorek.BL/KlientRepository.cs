using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaczorek.BL
{
    public class KlientRepository
    {
        private AdresRepository adresRepository { get; set; }

        public KlientRepository()
        {
            adresRepository = new AdresRepository();
        }


        /// <summary>
        /// Pobieramy jednego wskazanego klienta
        /// </summary>
        /// <param name="KlientId"></param>
        /// <returns></returns>
        public Klient Pobierz(int klientId)
        {
            //Tworzymy nową instacncje klienta
            Klient klient = new Klient(klientId);
            klient.ListaAdresow = adresRepository.PobierzPoKlientId(klientId).ToList();
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
        public bool Zapisz(Klient klient)
        {
            // kod który zapisuje zdefiniowanego klienta
            var sukces = true;

            if (klient.MaZmiany && klient.DanePrawidlowe)
            {
                if (klient.JestNowy)
                {
                    //wywołaj procedurę insert
                }
                else
                {
                    // wywołaj procedurę update
                }
            }
            return sukces;
        }
    }
    }

