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
        [TestMethod]
        public void SofaIdPropertyOK()
        {
            clsSofa ASofa = new clsSofa();
            Int32 TestData = 1; ;
            ASofa.SofaId = TestData;
            Assert.AreEqual(ASofa.SofaId, TestData);
        }
        [TestMethod]
        public void SofaSupplierIdPropertyOK()
        {
            clsSofa ASofa = new clsSofa();
            Int32 TestData = 1; ;
            ASofa.SupplierId = TestData;
            Assert.AreEqual(ASofa.SupplierId, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsSofa ASofa = new clsSofa();
            DateTime TestData = DateTime.Now.Date;
            ASofa.DateAdded = TestData;
            Assert.AreEqual(ASofa.DateAdded, TestData);
        }
        [TestMethod]
        public void SofaDescriptionPropertyOK()
        {
            clsSofa ASofa = new clsSofa();
            string TestData = "Big";
            ASofa.SofaDescription = TestData;
            Assert.AreEqual(ASofa.SofaDescription, TestData);
        }

        [TestMethod]
        public void SofaColourPropertyOK()
        {
            clsSofa ASofa = new clsSofa();
            string TestData = "Brown";
            ASofa.Colour = TestData;
            Assert.AreEqual(ASofa.Colour, TestData);
        }
        [TestMethod]
        public void SofaPricePropertyOK()
        {
            clsSofa ASofa = new clsSofa();
            decimal TestData = 349;
            ASofa.Price = TestData;
            Assert.AreEqual(ASofa.Price, TestData);
        }
        [TestMethod]
        public void SofaAvailbalePropertyOK()
        {
            clsSofa ASofa = new clsSofa();
            Boolean TestData = true;
            ASofa.Available = TestData;
            Assert.AreEqual(ASofa.Available, TestData);
        }
    }
}
