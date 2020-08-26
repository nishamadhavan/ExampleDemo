using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessing;

namespace OrderProcessingTests
{
    [TestClass]
    public class VideoTest
    {
        [TestMethod]
        public void ProcessOrdersTest()
        {
            Video v = new Video();
            string expectedString = v.ProcessOrders();
            string actualString = "For the Video Learning to Ski we have added another video First Aid in the packing slip";
            Assert.AreEqual(expectedString, actualString);
        }
    }
}
