using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using iCompass;

namespace iCompassTests
{
    [TestClass]
    public class CompassRoseCardinalCalculatorTests
    {
        [TestMethod]
        public void GetCardinalFromHeading_0_Returns_n()
        {
            Assert.AreEqual("N", CompassRoseCardinalCalculator.GetCardinalFromHeading(0));
        }

        [TestMethod]
        public void GetCardinalFromHeading_360_Returns_n()
        {
            Assert.AreEqual("N", CompassRoseCardinalCalculator.GetCardinalFromHeading(360));
        }

        [TestMethod]
        public void GetCardinalFromHeading_22_5_Returns_nne()
        {
            Assert.AreEqual("NNE", CompassRoseCardinalCalculator.GetCardinalFromHeading(22.5));
        }

        [TestMethod]
        public void GetCardinalFromHeading_90_Returns_e()
        {
            Assert.AreEqual("E", CompassRoseCardinalCalculator.GetCardinalFromHeading(90));
        }

        [TestMethod]
        public void GetCardinalFromHeading_180_Returns_s()
        {
            Assert.AreEqual("S", CompassRoseCardinalCalculator.GetCardinalFromHeading(180));
        }

        [TestMethod]
        public void GetCardinalFromHeading_270_Returns_w()
        {
            Assert.AreEqual("W", CompassRoseCardinalCalculator.GetCardinalFromHeading(270));
        }

        [TestMethod]
        public void GetCardinalFromHeading_5_Returns_n()
        {
            Assert.AreEqual("N", CompassRoseCardinalCalculator.GetCardinalFromHeading(5));
        }

        [TestMethod]
        public void GetCardinalFromHeading_359_Returns_n()
        {
            Assert.AreEqual("N", CompassRoseCardinalCalculator.GetCardinalFromHeading(359));
        }

        [TestMethod]
        public void GetCardinalFromHeading_11_5_Returns_n()
        {
            Assert.AreEqual("N", CompassRoseCardinalCalculator.GetCardinalFromHeading(11.5));
        }

        [TestMethod]
        public void GetCardinalFromHeading_11_6_Returns_nne()
        {
            Assert.AreEqual("NNE", CompassRoseCardinalCalculator.GetCardinalFromHeading(11.6));
        }

        [TestMethod]
        public void GetCardinalFromHeading_185_Returns_s()
        {
            Assert.AreEqual("S", CompassRoseCardinalCalculator.GetCardinalFromHeading(185));
        }

    }
}
