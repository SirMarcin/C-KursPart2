using System;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonTest
{
    [TestClass]
    public class ObslugaStringaTest
    {
        [TestMethod]
        public void WstawSpacjeTest()
        {
            //arrange
            var zrodlo = "StółOgrodowy";
            var oczekiwana = "Stół Ogrodowy";

            var obslugaStringa = new ObslugaStringa();

            //act
            var aktualna = obslugaStringa.WstawSpacje(zrodlo);

            //assert
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void WstawSpacjeTestZeSpacja()
        {
            //arrange
            var zrodlo = "Stół Ogrodowy";
            var oczekiwana = "Stół Ogrodowy";

            var obslugaStringa = new ObslugaStringa();

            //act
            var aktualna = obslugaStringa.WstawSpacje(zrodlo);

            //assert
            Assert.AreEqual(oczekiwana, aktualna);
        }
    }
}
