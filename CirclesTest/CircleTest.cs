using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CirclesTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Math.PI * Math.Pow(5,2), Circles.Circle.Area(5));
        }
    }
}
