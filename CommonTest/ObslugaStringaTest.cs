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



            //act
            var aktualna = zrodlo.WstawSpacje();

            //assert
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void WstawSpacjeTestZeSpacja()
        {
            //arrange
            var zrodlo = "Stół Ogrodowy";
            var oczekiwana = "Stół Ogrodowy";



            //act
            var aktualna = zrodlo.WstawSpacje();

            //assert
            Assert.AreEqual(oczekiwana, aktualna);
        }
    }
}
