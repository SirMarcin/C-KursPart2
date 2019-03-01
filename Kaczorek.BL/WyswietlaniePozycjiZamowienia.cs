using System;

namespace Kaczorek.BL
{
    public class WyswietlaniePozycjiZamowienia
    {
        public int PozycjaZamowieniaId { get; private set; }
        public int Ilosc { get; set; }
        public string NazwaProduktu { get; set; }
        public Decimal? CenaZakupu { get; set; }
    }
}