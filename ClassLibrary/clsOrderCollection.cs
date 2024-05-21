using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsOrderCollection
    {
        // private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        // private member data for thisOrder
        clsOrder mThisOrder = new clsOrder();

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
        public int Add()
        {
            // adds the record to the database based on the values of mThisOrder
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@OrderName", mThisOrder.OrderName);
            DB.AddParameter("@SofaId", mThisOrder.SofaId);
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@StaffId", mThisOrder.StaffId);
            DB.AddParameter("@DateOrdered", mThisOrder.DateOrdered);
            DB.AddParameter("@OrderDispatched", mThisOrder.OrderDispatched);

            // execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            // update an existing record based on the values of thisOrder
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the new stored procedure
            DB.AddParameter("OrderId", mThisOrder.OrderId);
            DB.AddParameter("@OrderName", mThisOrder.OrderName);
            DB.AddParameter("@SofaId", mThisOrder.SofaId);
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@StaffId", mThisOrder.StaffId);
            DB.AddParameter("@DateOrdered", mThisOrder.DateOrdered);
            DB.AddParameter("@OrderDispatched", mThisOrder.OrderDispatched);
            // execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }

        public clsOrder ThisOrder
        {
            get
            {
                // return the private data
                return mThisOrder;
            }
            set
            {
                // set the private data
                mThisOrder = value;
            }
        }

        // constructor for class
        public clsOrderCollection() 
        {
            //variable for the index
            Int32 Index = 0;
            // variable for record count
            Int32 RecordCount = 0;
            // object for the data connect
            clsDataConnection DB = new clsDataConnection();
            // execute stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            // get count of records
            RecordCount = DB.Count;
            // while there are records to process
            while (Index < RecordCount)
            {
                // create a blank order
                clsOrder AnOrder = new clsOrder();
                // read in the fields for the current record
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.OrderName = Convert.ToString(DB.DataTable.Rows[Index]["OrderName"]);
                AnOrder.SofaId = Convert.ToInt32(DB.DataTable.Rows[Index]["SofaId"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrder.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnOrder.DateOrdered = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOrdered"]);
                AnOrder.OrderDispatched = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderDispatched"]);
                // add record to private data member
                mOrderList.Add(AnOrder);
                // point at next record
                Index++;
            }

        }
    }
}
