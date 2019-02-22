using System;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class ZamowienieRepository
    {


        /// <summary>
        /// Pobieramy jedno zamowienie
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {
            // kod, który pobiera określone zamowienie

            //instancja zamowienia
            Zamowienie zamowienie = new Zamowienie(zamowienieId);

            if (zamowienieId == 1)
            {
                zamowienie.DataZamowienia = new DateTimeOffset(2018, 4, 20, 11, 00, 00, new TimeSpan(7, 0, 0));
            }
            return zamowienie;
        }

        /// <summary>
        /// Pobiera wszystkie zamowienia
        /// </summary>
        /// <returns></returns>
        public List<Zamowienie> Pobierz()
        {
            // kod, który pobiera wszystkie zamowienia
            return new List<Zamowienie>();
        }

        /// <summary>
        /// Zapisuje zamowienie
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // kod który zapisuje zdefiniowane zamowienie
            return true;
        }
    }
}
