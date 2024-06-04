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

        public void Delete()
        {
            // deletes the record pointed to by thisOrder
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the sotred procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            // execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByOrderName(string OrderName)
        {
            // filters the records based on a full or partial order name
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // send the OrderName parameter to the database
            DB.AddParameter("OrderName", OrderName);
            // execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderName");
            // populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            // populates the array list based on the data table in the parameter DB
            // variable for the index
            Int32 Index = 0;
            // variable to store the record count
            Int32 RecordCount;
            // get the record counts
            RecordCount = DB.Count;
            // clear the private array list
            mOrderList = new List<clsOrder>();
            // while there are records to process
            while (Index < RecordCount)
            {
                // create a blank order object
                clsOrder AnOrder = new clsOrder();
                // read the fields from the current record
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.OrderName = Convert.ToString(DB.DataTable.Rows[Index]["OrderName"]);
                AnOrder.SofaId = Convert.ToInt32(DB.DataTable.Rows[Index]["SofaId"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrder.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnOrder.DateOrdered = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOrdered"]);
                AnOrder.OrderDispatched = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderDispatched"]);
                // add the record to the private data member
                mOrderList.Add(AnOrder);
                // point at the next record
                Index++;
            }
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
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            // populate the array list with the data table
            PopulateArray(DB);
        }
    }
}
