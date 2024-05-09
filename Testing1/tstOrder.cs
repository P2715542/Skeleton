using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {
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

    }
}
