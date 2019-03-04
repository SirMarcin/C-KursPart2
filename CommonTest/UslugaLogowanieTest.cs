using System;
using System.Collections.Generic;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kaczorek.BL;

namespace CommonTest
{
    [TestClass]
    public class UslugaLogowanieTest
    {
        [TestMethod]
        public void PiszDoPlikuTest()
        {
            //arrange
            var zmienioneElementy = new List<ILogowanie>();
            var klient = new Klient(1)
            {
                Email = "admin@dev-hobby.pl",
                Imie = "Mariusz",
                Nazwisko = "Nowak",
                ListaAdresow = null
            };

            //act
            zmienioneElementy.Add(klient as ILogowanie);

            var produkt = new Produkt(1)
            {
                NazwaProduktu = "Klocki",
                Opis = "Klocki do zabawy",
                AktualnaCena = 100M
            };

            zmienioneElementy.Add(produkt as ILogowanie);

            var zamowienie = new Zamowienie(1)
            {
                DataZamowienia = new DateTime(2018, 9, 12, 11, 0, 0)
            };

            zmienioneElementy.Add(zamowienie as ILogowanie);
            UslugaLogowanie.PiszDoPliku(zmienioneElementy);
            //Assert

        }
    }
}
