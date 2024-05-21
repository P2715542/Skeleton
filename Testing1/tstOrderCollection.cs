using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create class instance
            clsOrderCollection AllOrders = new clsOrderCollection();
            // test if exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            // create class instance
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create some test data to assign to the property
            List<clsOrder> TestList = new List<clsOrder>();
            // Add item to the list
            // Create the item of test data
            clsOrder TestItem = new clsOrder();
            // Set its properties
            TestItem.OrderId = 1;
            TestItem.OrderName = "Order One";
            TestItem.SofaId = 1;
            TestItem.CustomerId = 1;
            TestItem.StaffId = 1;
            TestItem.DateOrdered = DateTime.Now;
            TestItem.OrderDispatched = false;
            // add item to the test list
            TestList.Add(TestItem);
            // Assign data to property
            AllOrders.OrderList = TestList;
            // test to see if the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.OrderId = 1;
            TestOrder.OrderName = "Order One";
            TestOrder.SofaId = 1;
            TestOrder.CustomerId = 1;
            TestOrder.StaffId = 1;
            TestOrder.DateOrdered = DateTime.Now;
            TestOrder.OrderDispatched = false;
            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // create class instance
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create some test data to assign to the property
            List<clsOrder> TestList = new List<clsOrder>();
            // Add item to the list
            // Create the item of test data
            clsOrder TestItem = new clsOrder();
            // Set its properties
            TestItem.OrderId = 1;
            TestItem.OrderName = "Order One";
            TestItem.SofaId = 1;
            TestItem.CustomerId = 1;
            TestItem.StaffId = 1;
            TestItem.DateOrdered = DateTime.Now;
            TestItem.OrderDispatched = false;
            // add item to the test list
            TestList.Add(TestItem);
            // Assign data to property
            AllOrders.OrderList = TestList;
            // test to see if the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            // create class instance
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create item for test data
            clsOrder TestItem = new clsOrder();
            // variable to store primary key
            Int32 PrimaryKey = 0;
            //set it's properties
            TestItem.OrderId = 1;
            TestItem.OrderName = "Some Order";
            TestItem.SofaId = 1;
            TestItem.CustomerId = 1;
            TestItem.StaffId = 1;
            TestItem.DateOrdered = DateTime.Now;
            TestItem.OrderDispatched = false;
            // set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            // add the record
            PrimaryKey = AllOrders.Add();
            // set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            // find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            // test to see if the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
    }
}
