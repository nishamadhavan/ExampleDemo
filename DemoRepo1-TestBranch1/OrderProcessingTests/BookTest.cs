using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessing;

namespace OrderProcessingTests
{
    [TestClass]
    public class BookTest
    {
        [TestMethod]
        public void ProcessOrdersTest()
        {
            Book p = new Book();
            string s = p.ProcessOrders();
            Assert.AreEqual(s, "Duplicate packing slip for the royalty department is generated and calculated commission as 2 %");
        }
    }
}
