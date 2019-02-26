using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class Klient
    {
        #region constructors
        public Klient() : this(0)
        {

        }
        public Klient(int klientId)
        {
            KlientId = klientId;
            ListaAdresow = new List<Adres>();
        }
        #endregion

        #region properties
        public static int Licznik { get; set; }
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
        public List<Adres> ListaAdresow { get; set; }
        public int TypKlienta { get; set; }

        #endregion

        #region methods
        /// <summary>
        /// Sprawdza dane klienta
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()
        {
            var poprawne = true;

            if (string.IsNullOrWhiteSpace(Nazwisko))
            {
                poprawne = false;
            }
            if (string.IsNullOrWhiteSpace(Email))
            {
                poprawne = false;
            }

            return poprawne;
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

        /// <summary>
        /// Pobieramy jednego wskazanego klienta
        /// </summary>
        /// <param name="KlientId"></param>
        /// <returns></returns>
        public Klient Pobierz(int klientId)
        {
            // kod, który pobiera określonego klienta
            return new Klient();
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
        #endregion
    }
}
