using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstSofa
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSofa AnAddress = new clsSofa();
            Assert.IsNotNull(AnAddress);
        }
    }
}
