using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessing;

namespace OrderProcessingTests
{
    [TestClass]
    public class UpgradeTest
    {
        [TestMethod]
        public void ProcessOrdersTest()
        {
            Upgrade u = new Upgrade();
            string expectedString = u.ProcessOrders();
            string actualString = "Membership is upgraded and Email is sent to Courteny@abc.com From Peter@contonso.com";
            Assert.AreEqual(expectedString, actualString);
        }
    }
}
