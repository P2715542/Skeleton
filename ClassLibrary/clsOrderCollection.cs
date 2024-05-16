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
