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
    }
}
