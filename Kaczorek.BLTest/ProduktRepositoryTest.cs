using System;
using Kaczorek.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kaczorek.BLTest
{
    [TestClass]
    public class ProduktRepositoryTest
    {
        [TestMethod]
        public void PobierzProduktTest()
        {
            //Arrange
            ProduktRepository produktRepository = new ProduktRepository();
            Produkt oczekiwana = new Produkt(1)
            {
                AktualnaCena = 100.99m,
                NazwaProduktu = "Obraz1",
                Opis = "Obraz wykonany techniką stringArt"
        };
            //Act
            Produkt aktualna = produktRepository.Pobierz(1);

            //Assert
            Assert.AreEqual(oczekiwana.NazwaProduktu, aktualna.NazwaProduktu);
            Assert.AreEqual(oczekiwana.Opis, aktualna.Opis);
            Assert.AreEqual(oczekiwana.ProduktId, aktualna.ProduktId);
            Assert.AreEqual(oczekiwana.AktualnaCena, aktualna.AktualnaCena);
        }
    }
}
