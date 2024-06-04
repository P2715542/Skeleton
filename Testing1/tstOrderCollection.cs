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

        [TestMethod]
        public void UpdateMethodOK()
        {
            // create class instance
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create item for test data
            clsOrder TestItem = new clsOrder();
            // variable to store primary key
            Int32 PrimaryKey = 0;
            //set it's properties
            TestItem.OrderId = 1;
            TestItem.OrderName = "New Order";
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
            // modify the test record
            TestItem.OrderName = "New Order";
            TestItem.SofaId = 3;
            TestItem.CustomerId = 4;
            TestItem.StaffId = 2;
            TestItem.DateOrdered = DateTime.Now;
            TestItem.OrderDispatched = false;
            // set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            // update the record
            AllOrders.Update();
            // find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            // test to see if ThisOrder matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // create class instance
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create item for test data
            clsOrder TestItem = new clsOrder();
            // variable to store primary key
            Int32 PrimaryKey = 0;
            //set it's properties
            TestItem.OrderId = 1;
            TestItem.OrderName = "New Order";
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
            // delete the record
            AllOrders.Delete();
            // now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            // test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByOrderNameMethodOK()
        {
            // create instance of class containing unfiltered results
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create instance of filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            // apply a blank string (Should return all records)
            FilteredOrders.ReportByOrderName("");
            // test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByOrderNameNoneFound()
        {
            // create instance of filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            // apply a order name that does not exist
            FilteredOrders.ReportByOrderName("Order Zero");
            // test to see that there are no records
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByOrderNameTestDataFound()
        {
            // create instance of filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            // variable to store the outcome
            Boolean OK = true;
            // apply an order name that doesn't exist
            FilteredOrders.ReportByOrderName("Order Ten");
            // check that the correct number of records are found
            if (FilteredOrders.Count == 2)
            {
                // check to see if the first record is 25
                if (FilteredOrders.OrderList[0].OrderId != 53)
                {
                    OK = false;
                }
                // check to see if the first record is 26
                if (FilteredOrders.OrderList[1].OrderId != 54)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            // test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
