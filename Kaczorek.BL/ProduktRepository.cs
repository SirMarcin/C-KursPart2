using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class ProduktRepository
    {
       
        /// <summary>
        /// Pobieramy jeden wskazany produkt
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public Produkt Pobierz(int produktId)
        {
            // kod, który pobiera określony produkt
            Produkt produkt = new Produkt(produktId);

            if (produktId == 1)
            {
                produkt.AktualnaCena = 100.99m;
                produkt.NazwaProduktu = "Obraz1";
                produkt.Opis = "Obraz wykonany techniką stringArt";
            }

            return produkt;
        }

        /// <summary>
        /// Pobiera wszystkie produkty
        /// </summary>
        /// <returns></returns>
        public List<Produkt> Pobierz()
        {
            // kod, który pobiera wszystkich klientów
            return new List<Produkt>();
        }

        /// <summary>
        /// Zapisuje produkt
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // kod który zapisuje zdefiniowany produkt
            return true;
        }

    }
}
