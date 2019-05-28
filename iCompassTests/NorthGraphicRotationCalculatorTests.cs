using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using iCompass;

namespace iCompassTests
{
    [TestClass]
    public class NorthGraphicRotationCalculatorTests
    {
        [TestMethod]
        public void GetRotationFromHeading_0_returns_0()
        {
            Assert.AreEqual(0, NorthGraphicRotationCalculator.GetRotationFromHeading(0));
        }

        [TestMethod]
        public void GetRotationFromHeading_180_returns_neg180()
        {
            Assert.AreEqual(-180, NorthGraphicRotationCalculator.GetRotationFromHeading(180));
        }

        [TestMethod]
        public void GetRotationFromHeading_45_returns_neg45()
        {
            Assert.AreEqual(-45, NorthGraphicRotationCalculator.GetRotationFromHeading(45));
        }

        [TestMethod]
        public void GetRotationFromHeading_300_returns_neg300()
        {
            Assert.AreEqual(-300, NorthGraphicRotationCalculator.GetRotationFromHeading(300));
        }
    }
}
