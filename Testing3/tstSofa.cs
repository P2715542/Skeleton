using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingSofa
{
    [TestClass]
    public class tstSofa
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSofa ASofa = new clsSofa();
            Assert.IsNotNull(ASofa);
        }
    }
}
