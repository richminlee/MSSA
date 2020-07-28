using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5.0,Geometry.Class1.CalcAreaTriangle(2.0,5.0));
        }
    }
}
