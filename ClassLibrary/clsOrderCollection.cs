using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        public List<clsOrder> OrderList
        {
            get
            {
                // return the private data
                return mOrderList;
            }
            set
            {
                // set the private value
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                // return count of the list
                return mOrderList.Count;
            }
            set
            {

            }
        }
        public clsOrder ThisOrder { get; set; }

        // constructor for class
        public clsOrderCollection() 
        {
            // create the items of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderId = 1;
            TestItem.OrderName = "Order One";
            TestItem.SofaId = 1;
            TestItem.CustomerId = 1;
            TestItem.StaffId = 1;
            TestItem.DateOrdered = DateTime.Now;
            TestItem.OrderDispatched = false;
            // add the test item to test list
            mOrderList.Add(TestItem);
            // re initialise the object for new data
            TestItem = new clsOrder();
            // set its properties
            TestItem.OrderId = 2;
            TestItem.OrderName = "Order Two";
            TestItem.SofaId = 2;
            TestItem.CustomerId = 2;
            TestItem.StaffId = 2;
            TestItem.DateOrdered = DateTime.Now;
            TestItem.OrderDispatched = false;
            // add the item to the test list
            mOrderList.Add(TestItem);
        }
    }
}
