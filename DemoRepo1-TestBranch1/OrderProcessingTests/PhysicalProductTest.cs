using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessing;

namespace OrderProcessingTests
{
    [TestClass]
    public class PhysicalProductTest
    {
        [TestMethod]
        public void ProcessOrdersTest()
        {
            PhysicalProduct p = new PhysicalProduct();
            string s=p.ProcessOrders();
            Assert.AreEqual(s, "Packing slip for shipping is generated and calculated commission as 5 %");
        }
    }
}
