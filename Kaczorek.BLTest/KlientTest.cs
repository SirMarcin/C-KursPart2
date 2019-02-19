using System;
using Kaczorek.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kaczorek.BLTest
{
    [TestClass]
    public class KlientTest
    {
        [TestMethod]
        public void ImieNazwiskoTest()
        {
            // Arrange (przygotuj  test)
            Klient klient = new Klient();
            klient.Imie = "Marcin";
            klient.Nazwisko = "Buczyński";

            string expected = "Marcin, Buczyński";

            // Act (działaj)
            string actual = klient.ImieNazwisko;

            // Assert (potwierdź test)
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ImieNazwiskoImiePusteTest()
        {
            // Arrange (przygotuj  test)
            Klient klient = new Klient();
            klient.Nazwisko = "Buczyński";

            string expected = "Buczyński";

            // Act (działaj)
            string actual = klient.ImieNazwisko;

            // Assert (potwierdź test)
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ImieNazwiskoNazwiskoPusteTest()
        {
            // Arrange (przygotuj  test)
            Klient klient = new Klient();
            klient.Imie = "Marcin";

            string expected = "Marcin";

            // Act (działaj)
            string actual = klient.ImieNazwisko;

            // Assert (potwierdź test)
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            // Arrange (przygotuj  test)
            var klient1 = new Klient();
            klient1.Imie = "Jacek";
            Klient.Licznik += 1;

            var klient2 = new Klient();
            klient2.Imie = "Tomek";
            Klient.Licznik += 1;

            var klient3 = new Klient();
            klient3.Imie = "Marcin";
            Klient.Licznik += 1;

            // Act (działaj)


            // Assert (potwierdź test)
            Assert.AreEqual(3, Klient.Licznik);
        }

        [TestMethod]
        public void ZwalidujTest()
        {
            // Arrange (przygotuj  test)
            Klient klient = new Klient();
            klient.Nazwisko = "Buczyński";
            klient.Email = "m.buczynski93@gmail.com";
            var oczekiwana = true;

            // Act (działaj)
            var aktualna = klient.Zwaliduj();

            // Assert (potwierdź test)
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void ZwalidujBrakNazwiskaTest()
        {
            // Arrange (przygotuj  test)
            Klient klient = new Klient();
            klient.Nazwisko = "";
            klient.Email = "m.buczynski93@gmail.com";
            var oczekiwana = false;

            // Act (działaj)
            var aktualna = klient.Zwaliduj();

            // Assert (potwierdź test)
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void ZwalidujBrakEmailTest()
        {
            // Arrange (przygotuj  test)
            Klient klient = new Klient();
            klient.Nazwisko = "Buczyński";
            klient.Email = "";
            var oczekiwana = false;

            // Act (działaj)
            var aktualna = klient.Zwaliduj();

            // Assert (potwierdź test)
            Assert.AreEqual(oczekiwana, aktualna);
        }


    }
}
