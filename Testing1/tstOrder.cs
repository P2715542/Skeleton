using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {
        // good test data
        //create some test data to pass the method
        string OrderName = "Order One";
        string SofaId = "1";
        string CustomerId = "1";
        string StaffId = "1";
        string DateOrdered = DateTime.Now.ToShortDateString();

        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class I wish to create
            clsOrder AnOrder = new clsOrder();
            // Test it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            // Create instance of class wished to be created
            clsOrder AnOrder = new clsOrder();
            // Create some test data to assign
            int TestData = 1;
            // Assign data to property
            AnOrder.OrderId = TestData;
            // Test to see if two values are same
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }

        [TestMethod]
        public void OrderNamePropertyOK()
        {
            // Create instance of class wished to be created
            clsOrder AnOrder = new clsOrder();
            // Create some test data to assign
            string TestData = "Jake Spaul";
            // Assign data to property
            AnOrder.OrderName = TestData;
            // Test to see if two values are same
            Assert.AreEqual(AnOrder.OrderName, TestData);
        }

        [TestMethod]
        public void SofaIdPropertyOK()
        {
            // Create instance of class wished to be created
            clsOrder AnOrder = new clsOrder();
            // Create some test data to assign
            int TestData = 1;
            // Assign data to property
            AnOrder.SofaId = TestData;
            // Test to see if two values are same
            Assert.AreEqual(AnOrder.SofaId, TestData);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            // Create instance of class wished to be created
            clsOrder AnOrder = new clsOrder();
            // Create some test data to assign
            int TestData = 1;
            // Assign data to property
            AnOrder.CustomerId = TestData;
            // Test to see if two values are same
            Assert.AreEqual(AnOrder.CustomerId, TestData);
        }

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            // Create instance of class wished to be created
            clsOrder AnOrder = new clsOrder();
            // Create some test data to assign
            int TestData = 1;
            // Assign data to property
            AnOrder.StaffId = TestData;
            // Test to see if two values are same
            Assert.AreEqual(AnOrder.StaffId, TestData);
        }

        [TestMethod]
        public void DateOrderedPropertyOK()
        {
            // Create instance of class wished to be created
            clsOrder AnOrder = new clsOrder();
            // Create some test data to assign
            DateTime TestData = DateTime.Now.Date;
            // Assign data to property
            AnOrder.DateOrdered = TestData;
            // Test to see if two values are same
            Assert.AreEqual(AnOrder.DateOrdered, TestData);
        }

        [TestMethod]
        public void OrderDispatchedPropertyOK()
        {
            // Create instance of class wished to be created
            clsOrder AnOrder = new clsOrder();
            // Create some test data to assign
            Boolean TestData = true;
            // Assign data to property
            AnOrder.OrderDispatched = TestData;
            // Test to see if two values are same
            Assert.AreEqual(AnOrder.OrderDispatched, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            // create instance of class
            clsOrder AnOrder = new clsOrder();
            // create boolean variable for validation result
            Boolean Found = false;
            // create some test data
            Int32 OrderId = 2;
            // invoke the method
            Found = AnOrder.Find(OrderId);
            // test if result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            // create class instance
            clsOrder AnOrder = new clsOrder();
            // create boolean variable for result
            Boolean Found = false;
            // create boolean variable to record if data is ok
            Boolean OK = true;
            // test data
            Int32 OrderId = 5;
            // invoke the method
            Found = AnOrder.Find(OrderId);
            // check the order id
            if (AnOrder.OrderId != 5)
            {
                OK = false;
            }
            // test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOrderedFound()
        {
            // create class instance
            clsOrder AnOrder = new clsOrder();
            // create boolean variable for result
            Boolean Found = false;
            // create boolean variable to record if data is ok
            Boolean OK = true;
            // test data
            Int32 OrderId = 5;
            // invoke the method
            Found = AnOrder.Find(OrderId);
            // check the order id
            if (AnOrder.DateOrdered != Convert.ToDateTime("09/05/2024"))
            {
                OK = false;
            }
            // test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderNameFound()
        {
            // create class instance
            clsOrder AnOrder = new clsOrder();
            // create boolean variable for result
            Boolean Found = false;
            // create boolean variable to record if data is ok
            Boolean OK = false;
            // test data
            Int32 OrderId = 5;
            // invoke the method
            Found = AnOrder.Find(OrderId);
            // check the order id
            if (AnOrder.OrderName == "Order Five")
            {
                OK = true;
            }
            // test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSofaIdFound()
        {
            // create class instance
            clsOrder AnOrder = new clsOrder();
            // create boolean variable for result
            Boolean Found = false;
            // create boolean variable to record if data is ok
            Boolean OK = true;
            // test data
            Int32 OrderId = 5;
            // invoke the method
            Found = AnOrder.Find(OrderId);
            // check the order id
            if (AnOrder.SofaId != 1)
            {
                OK = false;
            }
            // test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            // create class instance
            clsOrder AnOrder = new clsOrder();
            // create boolean variable for result
            Boolean Found = false;
            // create boolean variable to record if data is ok
            Boolean OK = true;
            // test data
            Int32 OrderId = 5;
            // invoke the method
            Found = AnOrder.Find(OrderId);
            // check the order id
            if (AnOrder.CustomerId != 1)
            {
                OK = false;
            }
            // test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            // create class instance
            clsOrder AnOrder = new clsOrder();
            // create boolean variable for result
            Boolean Found = false;
            // create boolean variable to record if data is ok
            Boolean OK = true;
            // test data
            Int32 OrderId = 5;
            // invoke the method
            Found = AnOrder.Find(OrderId);
            // check the order id
            if (AnOrder.StaffId != 1)
            {
                OK = false;
            }
            // test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDispatchedFound()
        {
            // create class instance
            clsOrder AnOrder = new clsOrder();
            // create boolean variable for result
            Boolean Found = false;
            // create boolean variable to record if data is ok
            Boolean OK = true;
            // test data
            Int32 OrderId = 5;
            // invoke the method
            Found = AnOrder.Find(OrderId);
            // check the order id
            if (AnOrder.OrderDispatched != false)
            {
                OK = false;
            }
            // test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            // create class instance
            clsOrder AnOrder = new clsOrder();
            // string variable to store error message
            string Error = "";
            // invoke method
            Error = AnOrder.Valid(OrderName,SofaId,CustomerId,StaffId,DateOrdered);
            // test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNameMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderName = "";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderNameMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderName = "a";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNameMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderName = "aa";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNameMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderName = "";
            OrderName = OrderName.PadRight(49, 'a');
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNameMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderName = "";
            OrderName = OrderName.PadRight(50, 'a');
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNameMaxPlus()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderName = "";
            OrderName = OrderName.PadRight(51, 'a');
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderNameMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderName = "";
            OrderName = OrderName.PadRight(25, 'a');
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNameExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderName = "";
            OrderName = OrderName.PadRight(1000, 'a');
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedExtremeMin()
        {
            // create class instance
            clsOrder AnOrder = new clsOrder();
            // create error variable
            String Error = "";
            // create date variable
            DateTime TestDate;
            // set variable to today's date
            TestDate = DateTime.Now.Date;
            // change date to date 100 years ago
            TestDate = TestDate.AddYears(-100);
            // change date to string
            string DateOrdered = TestDate.ToString();
            // invoke method
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            // test if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedMinMinusOne()
        {
            // create class instance
            clsOrder AnOrder = new clsOrder();
            // create error variable
            String Error = "";
            // create date variable
            DateTime TestDate;
            // set variable to today's date
            TestDate = DateTime.Now.Date;
            // change date to date yesterday
            TestDate = TestDate.AddDays(-1);
            // change date to string
            string DateOrdered = TestDate.ToString();
            // invoke method
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            // test if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedMin()
        {
            // create class instance
            clsOrder AnOrder = new clsOrder();
            // create error variable
            String Error = "";
            // create date variable
            DateTime TestDate;
            // set variable to today's date
            TestDate = DateTime.Now.Date;
            // change date to string
            string DateOrdered = TestDate.ToString();
            // invoke method
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            // test if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedMinPlusOne()
        {
            // create class instance
            clsOrder AnOrder = new clsOrder();
            // create error variable
            String Error = "";
            // create date variable
            DateTime TestDate;
            // set variable to today's date
            TestDate = DateTime.Now.Date;
            // change date to date tomorrow
            TestDate = TestDate.AddDays(1);
            // change date to string
            string DateOrdered = TestDate.ToString();
            // invoke method
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            // test if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedExtremeMax()
        {
            // create class instance
            clsOrder AnOrder = new clsOrder();
            // create error variable
            String Error = "";
            // create date variable
            DateTime TestDate;
            // set variable to today's date
            TestDate = DateTime.Now.Date;
            // change date to date yesterday
            TestDate = TestDate.AddYears(100);
            // change date to string
            string DateOrdered = TestDate.ToString();
            // invoke method
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            // test if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedInvalidData()
        {
            // create class instance
            clsOrder AnOrder = new clsOrder();
            // create error variable
            String Error = "";
            // set dateOrdered value to non date
            string DateOrdered = "fred";
            // invoke method
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            // test if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SofaIdExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string SofaId = "-2147483648";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SofaIdMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string SofaId = "0";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SofaIdMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string SofaId = "1";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SofaIdMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string SofaId = "2";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SofaIdMaxMinusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string SofaId = "2147483646";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SofaIdMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string SofaId = "2147483647";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SofaIdMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string SofaId = "2147483648";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SofaIdMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string SofaId = "1073741824";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SofaIdInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string SofaId = "fred";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustomerId = "-2147483648";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustomerId = "";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustomerId = "1";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustomerId = "2";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMaxMinusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustomerId = "2147483646";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustomerId = "2147483647";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustomerId = "2147483648";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustomerId = "1073741824";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustomerId = "fred";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string StaffId = "-2147483648";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string StaffId = "";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string StaffId = "1";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string StaffId = "2";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMaxMinusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string StaffId = "2147483646";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string StaffId = "2147483647";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string StaffId = "2147483648";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string StaffId = "1073741824";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string StaffId = "fred";
            Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
            Assert.AreNotEqual(Error, "");
        }
    }
}
