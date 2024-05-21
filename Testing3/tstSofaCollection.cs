using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstSofaCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSofaCollection AllSofas = new clsSofaCollection();
            Assert.IsNotNull(AllSofas);
        }

        [TestMethod]
        public void SofaListOK()
        {
            clsSofaCollection AllSofas = new clsSofaCollection();
            List<clsSofa> TestList = new List<clsSofa>();
            clsSofa TestItem = new clsSofa();
            TestItem.SofaId = 2;
            TestItem.SofaDescription = "Bigger";
            TestItem.Colour = "Brown";
            TestItem.SupplierId = 3;
            TestItem.Price = 266;
            TestItem.Available = true;
            TestItem.DateAdded = DateTime.Now;
            TestList.Add(TestItem);
            AllSofas.SofaList = TestList;
            Assert.AreEqual(AllSofas.SofaList, TestList);
        }

        

        [TestMethod]
        public void ThisSofaPropertyOK()
        {
            clsSofaCollection AllSofas = new clsSofaCollection();
            clsSofa TestSofa = new clsSofa();
            TestSofa.SofaId = 2;
            TestSofa.SofaDescription = "Bigger";
            TestSofa.Colour = "Brown";
            TestSofa.SupplierId = 3;
            TestSofa.Price = 266;
            TestSofa.Available = true;
            TestSofa.DateAdded = DateTime.Now;
            AllSofas.ThisSofa = TestSofa;
            Assert.AreEqual(AllSofas.ThisSofa, TestSofa);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsSofaCollection AllSofas = new clsSofaCollection();
            List<clsSofa> TestList = new List<clsSofa>();
            clsSofa TestItem = new clsSofa();
            TestItem.SofaId = 2;
            TestItem.SofaDescription = "Bigger";
            TestItem.Colour = "Brown";
            TestItem.SupplierId = 3;
            TestItem.Price = 266;
            TestItem.Available = true;
            TestItem.DateAdded = DateTime.Now;
            TestList.Add(TestItem);
            AllSofas.SofaList = TestList;
            Assert.AreEqual(AllSofas.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsSofaCollection AllSofas = new clsSofaCollection();
            clsSofa TestItem = new clsSofa();
            Int32 PrimaryKey = 0;
            TestItem.SofaId = 4;
            TestItem.SofaDescription = "Small";
            TestItem.Colour = "Blue";
            TestItem.SupplierId = 2;
            TestItem.Price = 233;
            TestItem.Available = true;
            TestItem.DateAdded = DateTime.Now;
            AllSofas.ThisSofa = TestItem;
            PrimaryKey = AllSofas.Add();
            TestItem.SofaId = PrimaryKey;
            AllSofas.ThisSofa.Find(PrimaryKey);
            Assert.AreEqual(AllSofas.ThisSofa, TestItem);



        }
    }
}
