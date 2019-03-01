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
        public bool Zapisz(Zamowienie zamowienie)
        {
            // kod który zapisuje zdefiniowane zamowienie
            var sukces = true;

            if (zamowienie.MaZmiany && zamowienie.DanePrawidlowe)
            {
                if (zamowienie.JestNowy)
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
        
        /// <summary>
        /// Pobieramy jedno zamówienie do wyświetlenia
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public WyswietlanieZamowienia PobierzZamowienieDoWyswietlenia(int zamowienieId)
        {
            WyswietlanieZamowienia wyswietlanieZamowienia = new WyswietlanieZamowienia();
            //Kod który pobiera zdefiniowane zamowienia z bazy
            //tymczasowe dane zakodowane na stałe
            if (zamowienieId == 1)
            {
                wyswietlanieZamowienia.Imie = "Jacek";
                wyswietlanieZamowienia.Nazwisko = "Kowal";
                wyswietlanieZamowienia.DataZamowienia = new DateTimeOffset(2019, 5, 21, 12, 00, 00, new TimeSpan(5, 0, 0));
                wyswietlanieZamowienia.AdresDostawy = new Adres()
                {
                    AdresTyp = "Adres domowy",
                    Ulica = "Mila",
                    Miasto = "Katowice",
                    Kraj = "Polska",
                    KodPocztowy = "44-345"
                };

                wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniasLista = new List<WyswietlaniePozycjiZamowienia>();

                //kod który pobiera elementy zamówienia

                // Tymczasowe dane zakodowane na stałe
                if (zamowienieId == 1)
                {
                    var wyswietlaniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Obraz2",
                        CenaZakupu = 50.50M,
                        Ilosc = 2
                    };
                    wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniasLista.Add(wyswietlaniePozycjiZamowienia);

                    wyswietlaniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Obraz3",
                        CenaZakupu = 80.20M,
                        Ilosc = 1
                    };
                    wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniasLista.Add(wyswietlaniePozycjiZamowienia);

                    
                }
            }

            return wyswietlanieZamowienia;
        }
    }
}
