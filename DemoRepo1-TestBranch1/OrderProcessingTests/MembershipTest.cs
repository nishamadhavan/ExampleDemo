using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessing;

namespace OrderProcessingTests
{
    [TestClass]
    public class MembershipTest
    {
        [TestMethod]
        public void ProcessOrdersTest()
        {
            Membership p = new Membership();
            string s = p.ProcessOrders();
            Assert.AreEqual(s, "Membership is activated and Email is sent to Susan@abc.com From Claire@contonso.com");
        }
    }
}
