using System;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class Zamowienie
    {
        
        #region constructors
        public Zamowienie()
        {

        }
        public Zamowienie(int zamoiwenieId)
        {
            ZamowienieId = zamoiwenieId;
        }
        #endregion

        #region properties
        public int ZamowienieId { get; private set; }
        public DateTimeOffset? DataZamowienia { get; set; }
        #endregion

        #region methods
        /// <summary>
        /// Sprawdza dane zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()
        {
            var poprawne = true;

            if (DataZamowienia == null)
            {
                poprawne = false;
            }
            return poprawne;
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

        /// <summary>
        /// Pobieramy jedno zamowienie
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {
            // kod, który pobiera określone zamowienie
            return new Zamowienie();
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
        #endregion
    }
}
