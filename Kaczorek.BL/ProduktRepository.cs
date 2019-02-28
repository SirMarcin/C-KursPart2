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
            //Tworzymy tymczasową instancję produktu do testów
            Produkt produkt = new Produkt(produktId);
            object mojObjekt = new object();

            System.Console.WriteLine("Obiekt : " + mojObjekt.ToString());
            System.Console.WriteLine("Produkt : " + produkt.ToString());
            // kod, który pobiera określony produkt
            //tymczasowo zakodowane testowe wartości aby zwrócić klienta
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
        public bool Zapisz(Produkt produkt)
        {
            // kod który zapisuje zdefiniowany produkt
            var sukces = true;

            if (produkt.MaZmiany && produkt.DanePrawidlowe)
            {
                if (produkt.JestNowy)
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
