using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

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
            TestItem.SofaDescription = "SofaName1v2";
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

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsSofaCollection AllSofas = new clsSofaCollection();
            clsSofa TestItem = new clsSofa();
            Int32 PrimaryKey = 0;
            TestItem.SofaId = 4;
            TestItem.SofaDescription = "SofaName1v2";
            TestItem.Colour = "Brown";
            TestItem.SupplierId = 2;
            TestItem.Price = 544;
            TestItem.Available = true;
            TestItem.DateAdded = DateTime.Now;
            AllSofas.ThisSofa = TestItem;
            PrimaryKey = AllSofas.Add();

            TestItem.SofaId = PrimaryKey;
            TestItem.SofaId = 6;
            TestItem.SofaDescription = "SofaName2v2";
            TestItem.Colour = "Green";
            TestItem.SupplierId = 2;
            TestItem.Price = 655;
            TestItem.Available = false;
            TestItem.DateAdded = DateTime.Now;
            AllSofas.ThisSofa = TestItem;
            AllSofas.Update();
            AllSofas.ThisSofa.Find(PrimaryKey);
            Assert.AreEqual(AllSofas.ThisSofa, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsSofaCollection AllSofas = new clsSofaCollection();
            clsSofa TestItem = new clsSofa();
            Int32 PrimaryKey = 0;
            TestItem.SofaId = 4;
            TestItem.SofaDescription = "SofaName3v2";
            TestItem.Colour = "Blue";
            TestItem.SupplierId = 2;
            TestItem.Price = 233;
            TestItem.Available = true;
            TestItem.DateAdded = DateTime.Now;
            AllSofas.ThisSofa = TestItem;
            PrimaryKey = AllSofas.Add();
            TestItem.SofaId = PrimaryKey;
            AllSofas.ThisSofa.Find(PrimaryKey);
            AllSofas.Delete();
            Boolean Found = AllSofas.ThisSofa.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportBySofaColourMethodOk()
        {
            clsSofaCollection AllSofas = new clsSofaCollection();
            clsSofaCollection FilteredSofas = new clsSofaCollection();
            FilteredSofas.ReportByDescription("");
            Assert.AreEqual(AllSofas.Count, FilteredSofas.Count);
        }

        [TestMethod]
        public void ReportBySofaColourNoneFound()
        {
            clsSofaCollection FilteredSofas = new clsSofaCollection();
            FilteredSofas.ReportByDescription("xxxx");
            Assert.AreEqual(0, FilteredSofas.Count);
        }

        [TestMethod]
        public void ReportBySofaDescriptionTestDataFound()
        {
            clsSofaCollection FilteredSofas = new clsSofaCollection();
            Boolean OK = true;
            FilteredSofas.ReportByDescription("SofaName5v1");
            if (FilteredSofas.Count == 2)
            {
                if (FilteredSofas.SofaList[0].SofaId != 116)
                {
                    OK = false;
                }

                if (FilteredSofas.SofaList[1].SofaId != 117)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
