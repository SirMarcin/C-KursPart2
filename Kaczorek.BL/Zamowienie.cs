﻿using Common;
using System;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class Zamowienie : KlasaBazowa, ILogowanie
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

        public PozycjaZamowienia pozycjaZamowienia { get; set; }
        public int KlientId { get; set; }
        public int AdresDostawyId { get; set; }
        #endregion

        #region methods
        /// <summary>
        /// Sprawdza dane zamowienia
        /// </summary>
        /// <returns></returns>
        public override bool Zwaliduj()
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

        public override string ToString()
        {
            return DataZamowienia.Value.Date + " (" + ZamowienieId +") ";
        }

        public string Log()
        {
            var log = ZamowienieId + ": " + "Data: " + DataZamowienia.Value.ToString() + " " + "Status: " + StanObiektu.ToString();
            return log; ;
        }
        #endregion
    }
}
