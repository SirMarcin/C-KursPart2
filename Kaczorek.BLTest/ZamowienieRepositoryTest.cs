using System;
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
    }
}
