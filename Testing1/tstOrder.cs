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

    }
}
