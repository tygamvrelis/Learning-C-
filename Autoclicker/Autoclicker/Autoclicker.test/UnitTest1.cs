using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Autoclicker.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Clicker testClicker = new Clicker();
            Assert.AreEqual(false, Clicker.testFlag);
        }
    }
}
