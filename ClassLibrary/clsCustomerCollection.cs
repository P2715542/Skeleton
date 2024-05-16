using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //public property for the customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the private data
                return mCustomerList.Count;
            }
            set
            {

            }
        }


        public clsCustomer ThisCustomer { get; set; }



        //constructor for the class
        public clsCustomerCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the database connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of the record to process
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields for the current record
                AnCustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnCustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnCustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnCustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnCustomer.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                AnCustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                //add the record to the private data member
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;
            }
        }

    }
}