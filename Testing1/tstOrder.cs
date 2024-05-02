using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void TestMethod1()
        {
            // create an instance of the class I wish to create
            clsOrder AnOrder = new clsOrder();
            // Test it exists
            Assert.IsNotNull(AnOrder);
        }
    }
}
