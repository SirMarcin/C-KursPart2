using System;
using System.Collections.Generic;
using Kaczorek.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kaczorek.BLTest
{
    [TestClass]
    public class KlientRepositoryTest
    {
        [TestMethod]
        public void PobierzKlientaTest()
        {
            //arrange
            var klientRepository = new KlientRepository();
            var oczekiwana = new Klient(1)
            {
                Email = "m.buczynski93@gmail.com",
                Imie = "Marcin",
                Nazwisko = "Buczyński"
            };
            //act
            var aktualna = klientRepository.Pobierz(1);
            //assert
            //Assert.AreEqual(oczekiwana, aktualna);
            Assert.AreEqual(oczekiwana.KlientId, aktualna.KlientId);
            Assert.AreEqual(oczekiwana.Email, aktualna.Email);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);
        }
        [TestMethod]
        public void PobierzKlientaZAdresamiTest()
        {
            //arrange
            KlientRepository klientRepository = new KlientRepository();
            var oczekiwana = new Klient(1)
            {
                Email = "m.buczynski93@gmail.com",
                Imie = "Marcin",
                Nazwisko = "Buczyński",
                ListaAdresow = new List<Adres>()
                {
                    new Adres()
                    {
                        AdresTyp = "AdresDomowy",
                        KodPocztowy = "94-045",
                        Kraj = "Polska",
                        Miasto = "Łódź",
                        Ulica = "Przełajowa"
                    },
                    new Adres()
                    {
                        AdresTyp = "AdresBiurowy",
                        KodPocztowy = "54-123",
                        Kraj = "Polska",
                        Miasto = "Warszawa",
                        Ulica = "Łazienkowska"
                    }
                }
            };
            //act
            var aktualna = klientRepository.Pobierz(1);
            //Assert
            Assert.AreEqual(oczekiwana.KlientId, aktualna.KlientId);
            Assert.AreEqual(oczekiwana.Email, aktualna.Email);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(oczekiwana.ListaAdresow[i].AdresTyp, aktualna.ListaAdresow[i].AdresTyp);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].KodPocztowy, aktualna.ListaAdresow[i].KodPocztowy);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Ulica, aktualna.ListaAdresow[i].Ulica);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Kraj, aktualna.ListaAdresow[i].Kraj);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Miasto, aktualna.ListaAdresow[i].Miasto);

            }
        }
    }
}
