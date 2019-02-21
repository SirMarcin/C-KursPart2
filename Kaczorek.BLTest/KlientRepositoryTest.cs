using System;
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
    }
}
