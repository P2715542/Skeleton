using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Reflection.Emit;

namespace TestingSofa
{
    [TestClass]
    public class tstSofa
    {
        string SofaDescription = "Big";
        string SofaColour = "Blue";
        string SupplierId = 1.ToString();
        string Price = 233.ToString();
        string DateAdded = DateTime.Now.ToShortDateString();

        [TestMethod]
        public void InstanceOK()
        {
            clsSofa ASofa = new clsSofa();
            Assert.IsNotNull(ASofa);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsSofa ASofa = new clsSofa();
            Boolean Found = false;
            Int32 SofaId = 1;
            Found = ASofa.Find(SofaId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void SofaDescriptionMinLessOne()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string SofaDescription = "";
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SofaDescriptionMin()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string SofaDescription = "a";
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SofaDescriptionMinPlusOne()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string SofaDescription = "aa";
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SofaDescriptionMaxLessOne()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string SofaDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SofaDescriptionMax()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string SofaDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SofaDescriptionMaxPlusOne()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string SofaDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SofaDescriptionMid()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string SofaDescription = "aaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SofaDescriptionExtremeMax()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string SofaDescription = "";
            SofaDescription = SofaDescription.PadRight(1000, 'a');
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SofaColourMinLessOne()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string SofaColour = "";
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SofaColourMin()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string SofaColour = "a";
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SofaColourMinPlusOne()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string SofaColour = "aa";
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SofaColourMaxLessOne()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string SofaColour = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SofaColourMax()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string SofaColour = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SofaColourMaxPlusOne()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string SofaColour = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SofaColourMid()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string SofaColour = "aaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SofaColourExtremeMax()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string SofaColour = "";
            SofaColour = SofaColour.PadRight(1000, 'a');
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierMinLessOne()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string SupplierId = Convert.ToString(0);
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIdMin()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string SupplierId = Convert.ToString(1);
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIdMinPlusOne()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string SupplierId = Convert.ToString(2);
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierMaxLessOne()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string SupplierId = Convert.ToString(2147483646);
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIdMax()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string SupplierId = Convert.ToString(2147483647);
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIdMaxPlusOne()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string SupplierId = Convert.ToString(2147483648);
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string Price = Convert.ToString(-1.00);
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string Price = Convert.ToString(0.00);
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string Price = Convert.ToString(1.00);
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string Price = Convert.ToString(9998.99);
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string Price = Convert.ToString(9999.99);
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            string Price = Convert.ToString(10000.99);
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string DateAdded = TestDate.ToString();
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateAdded = TestDate.ToString();
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(1);
            string DateAdded = TestDate.ToString();
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsSofa ASofa = new clsSofa();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateAdded = TestDate.ToString();
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsSofa ASofa = new clsSofa();
            String Error = "";
            string DateAdded = "fred";
            Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void TestSofaIdFound()
        {
            clsSofa ASofa = new clsSofa();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SofaId = 3;
            Found = ASofa.Find(SofaId);
            if (ASofa.SofaId != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK); 
        }

        [TestMethod]
        public void TestSofaDescriptionFound()
        {
            clsSofa ASofa = new clsSofa();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SofaId = 3;
            Found = ASofa.Find(SofaId);
            if (ASofa.SofaDescription != "SofaName3v1")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSofaColourFound()
        {
            clsSofa ASofa = new clsSofa();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SofaId = 3;
            Found = ASofa.Find(SofaId);
            if (ASofa.Colour != "Red")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierIdFound()
        {
            clsSofa ASofa = new clsSofa();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SofaId = 3;
            Found = ASofa.Find(SofaId);
            if (ASofa.SupplierId != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            clsSofa ASofa = new clsSofa();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SofaId = 3;
            Found = ASofa.Find(SofaId);
            if (ASofa.Price != 554)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            clsSofa ASofa = new clsSofa();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SofaId = 3;
            Found = ASofa.Find(SofaId);
            if (ASofa.Available != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsSofa ASofa = new clsSofa();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SofaId = 3;
            Found = ASofa.Find(SofaId);
            if (ASofa.DateAdded != Convert.ToDateTime("14/07/2023"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
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
