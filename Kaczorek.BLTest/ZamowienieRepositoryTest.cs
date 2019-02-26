using System;
using System.Collections.Generic;
using System.Linq;
using Kaczorek.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kaczorek.BLTest
{
    [TestClass]
    public class ZamowienieRepositoryTest
    {
        [TestMethod]
        public void PobierzZamowienieTest()
        {
            //arrange
            ZamowienieRepository zamowienieRepository = new ZamowienieRepository();

            Zamowienie oczekiwana = new Zamowienie(1)
            {
                DataZamowienia = new DateTimeOffset(2018, 4, 20, 11, 00, 00, new TimeSpan(7, 0, 0))
            };

            //act
            Zamowienie aktualna = zamowienieRepository.Pobierz(1);

            //assert
            Assert.AreEqual(oczekiwana.DataZamowienia, aktualna.DataZamowienia);
            Assert.AreEqual(oczekiwana.ZamowienieId, aktualna.ZamowienieId);
        }

        [TestMethod]
        public void PobierzZamowienieDowyswietleniaTest()
        {
            //Arrange
            var zamowienieRepository = new ZamowienieRepository();
            var oczekiwana = new WyswietlanieZamowienia()
            {
                Imie = "Jacek",
                Nazwisko = "Kowal",
                DataZamowienia = new DateTimeOffset(2019, 5, 21, 12, 00, 00, new TimeSpan(5, 0, 0)),
                AdresDostawy = new Adres()
                {
                    AdresTyp = "Adres domowy",
                    Ulica = "Mila",
                    Miasto = "Katowice",
                    Kraj = "Polska",
                    KodPocztowy = "44-345"
                },
                WyswietlaniePozycjiZamowieniasLista = new List<WyswietlaniePozycjiZamowienia>()
                {
                    new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Obraz2",
                        CenaZakupu = 50.50M,
                        Ilosc = 2
                    },
                    new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Obraz3",
                        CenaZakupu = 80.20M,
                        Ilosc = 1
                    }
                }
            };

            //act
            var aktualna = zamowienieRepository.PobierzZamowienieDoWyswietlenia(1);

            //assert
            Assert.AreEqual(oczekiwana.ZamowienieId, aktualna.ZamowienieId);
            Assert.AreEqual(oczekiwana.DataZamowienia, aktualna.DataZamowienia);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);

            Assert.AreEqual(oczekiwana.AdresDostawy.KodPocztowy, aktualna.AdresDostawy.KodPocztowy);
            Assert.AreEqual(oczekiwana.AdresDostawy.AdresTyp, aktualna.AdresDostawy.AdresTyp);
            Assert.AreEqual(oczekiwana.AdresDostawy.Kraj, aktualna.AdresDostawy.Kraj);
            Assert.AreEqual(oczekiwana.AdresDostawy.Miasto, aktualna.AdresDostawy.Miasto);
            Assert.AreEqual(oczekiwana.AdresDostawy.Ulica, aktualna.AdresDostawy.Ulica);

            for (int i = 0; i < oczekiwana.WyswietlaniePozycjiZamowieniasLista.Count()-1; i++)
            {
                Assert.AreEqual(oczekiwana.WyswietlaniePozycjiZamowieniasLista[i].CenaZakupu, aktualna.WyswietlaniePozycjiZamowieniasLista[i].CenaZakupu);
                Assert.AreEqual(oczekiwana.WyswietlaniePozycjiZamowieniasLista[i].Ilosc, aktualna.WyswietlaniePozycjiZamowieniasLista[i].Ilosc);
                Assert.AreEqual(oczekiwana.WyswietlaniePozycjiZamowieniasLista[i].NazwaProduktu, aktualna.WyswietlaniePozycjiZamowieniasLista[i].NazwaProduktu);
            }

        }
    }
}
