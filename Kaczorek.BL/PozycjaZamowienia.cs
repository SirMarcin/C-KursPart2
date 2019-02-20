namespace Kaczorek.BL
{
    public class PozycjaZamowienia
    {
        #region contructors
        public PozycjaZamowienia()
        {

        }
        public PozycjaZamowienia(int pozycjaZamowieniaId)
        {
            PozycjaZamowieniaId = pozycjaZamowieniaId;
        }
        #endregion

        #region properties
        public int PozycjaZamowieniaId { get; private set; }
        public int Ilosc { get; set; }
        public int ProduktId { get; set; }
        public decimal? CenaZaupu { get; set; }
        #endregion

        #region methods
        /// <summary>
        /// Sprawdza dane pozycji zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()
        {
            var poprawne = true;

            if (Ilosc <= 0)
            {
                poprawne = false;
            }
            if (ProduktId <=0)
            {
                poprawne = false;
            }
            if (CenaZaupu == 0)
            {
                poprawne = false;
            }
            return poprawne;
        }

        /// <summary>
        /// Zapisuje element zamowienia
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
        /// <param name="pozycjaZamowieniaId"></param>
        /// <returns></returns>
        public PozycjaZamowienia Pobierz(int pozycjaZamowieniaId)
        {
            // kod, który pobiera element zamowienia
            return new PozycjaZamowienia();
        }
        #endregion
    }
}
