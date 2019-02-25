using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaczorek.BL
{
    class AdresRepository
    {
        /// <summary>
        /// Pobieramy jednego adres wskazanego klienta
        /// </summary>
        /// <param name="AdresId"></param>
        /// <returns></returns>
        public Adres Pobierz(int adresId)
        {
            //Tworzymy nową instacncje adresu
            Adres adres = new Adres(adresId);
            // kod, który pobiera określony adres
            //tymczasowo zakodowane wartości aby zwrócić adres
            if (adresId == 1)
            {
                adres.AdresTyp = "AdresDomowy";
                adres.KodPocztowy = "94-045";
                adres.Kraj = "Polska";
                adres.Miasto = "Łódź";
                adres.Ulica = "Przełajowa";
            };

            return adres;
        }
        /// <summary>
        /// kod, który pobierawszystkie adresy podanego klienta
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Adres> PobierzPoKlientId(int klientId)
        {
            // kod, który pobierawszystkie adresy podanego klienta
            // Tymczasowo zakodowane wartości do zwrócenia, zestaw adresów

            var listaAdresow = new List<Adres>();

            Adres adres = new Adres(1)
            {
            AdresTyp = "AdresDomowy",
            KodPocztowy = "94-045",
            Kraj = "Polska",
            Miasto = "Łódź",
            Ulica = "Przełajowa"
            };
            listaAdresow.Add(adres);

            adres = new Adres(2)
            {
                AdresTyp = "AdresBiurowy",
                KodPocztowy = "54-123",
                Kraj = "Polska",
                Miasto = "Warszawa",
                Ulica = "Łazienkowska"
            };
            listaAdresow.Add(adres);

            return listaAdresow;
        }

        /// <summary>
        /// Zapisuje adres
        /// </summary>
        /// <returns></returns>
        public bool Zapisz(Adres adres)
        {
            // kod który zapisuje zdefiniowany adres
            return true;
        }
    }
}
