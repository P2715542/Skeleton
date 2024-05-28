using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Find(int orderId)
        {
            // create instance of data connection
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the order id to search for
            DB.AddParameter("@OrderId", orderId);
            // execute stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            // if one record is found (Should be either xero or one
            if (DB.Count == 1)
            {
                // set the private data members to the test data value
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mDateOrdered = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOrdered"]);
                mOrderName = Convert.ToString(DB.DataTable.Rows[0]["OrderName"]);
                mSofaId = Convert.ToInt32(DB.DataTable.Rows[0]["SofaId"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mOrderDispatched = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderDispatched"]);
                // return that everything worked OK
                return true;
            }
            // if no record was found
            else
            {
                // return false indicating there is a problem
                return false;
            }
        }

        // private data member for the respective property
        private Int32 mOrderId;
        private DateTime mDateOrdered;
        private String mOrderName;
        private Int32 mSofaId;
        private Int32 mCustomerId;
        private Int32 mStaffId;
        private Boolean mOrderDispatched;


        // OrderId public property
        public Int32 OrderId {
            get {
                // sends data out of the property
                return mOrderId;
            } set {
                // allows data into the property
                mOrderId = value;
            }
        }
        public DateTime DateOrdered
        {
            get
            {
                // sends data out of the property
                return mDateOrdered;
            }
            set
            {
                // allows data into the property
                mDateOrdered = value;
            }
        }

        public String OrderName
        {
            get
            {
                // sends data out of the property
                return mOrderName;
            }
            set
            {
                // allows data into the property
                mOrderName = value;
            }
        }

        public Int32 SofaId
        {
            get
            {
                // sends data out of the property
                return mSofaId;
            }
            set
            {
                // allows data into the property
                mSofaId = value;
            }
        }

        public Int32 CustomerId
        {
            get
            {
                // sends data out of the property
                return mCustomerId;
            }
            set
            {
                // allows data into the property
                mCustomerId = value;
            }
        }

        public Int32 StaffId
        {
            get
            {
                // sends data out of the property
                return mStaffId;
            }
            set
            {
                // allows data into the property
                mStaffId = value;
            }
        }

        public bool OrderDispatched
        {
            get
            {
                // sends data out of the property
                return mOrderDispatched;
            }
            set
            {
                // allows data into the property
                mOrderDispatched = value;
            }
        }

        public string Valid(string OrderName, string SofaId, string CustomerId, string StaffId, string dateOrdered)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the HouseNo is blank
            if (OrderName.Length == 0)
            {
                //record the error
                Error = Error + "The order name may not be blank : ";
            }
            //if the house no is greater than 50 characters
            if (OrderName.Length > 50)
            {
                //record the error
                Error = Error + "The order name must be less than 50 characters : ";
            }
            //copy the dateAdded value to the DateTemp variable
            DateTime DateComp = DateTime.Now.Date;
            try
            {
                DateTemp = Convert.ToDateTime(dateOrdered);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }
            // try catch for if the data type isn't an integer
            try
            {
                // if sofa id is less than one
                if (Convert.ToInt32(SofaId) < 1)
                {
                    //record the error
                    Error = Error + "The sofa id may not be less than one : ";
                }
                // if sofa id is greater than max integer value
                if (Convert.ToInt32(SofaId) > 2147483647)
                {
                    //record the error
                    Error = Error + "The sofa id may not be greater than 2,147,483,647 : ";
                }
            }
            catch
            {
                Error = Error + "The sofa id was not an integer : ";

            }
            // try catch for if the data type isn't an integer
            try
            {
                // if customer id is less than one
                if (Convert.ToInt32(CustomerId) < 1)
                {
                    //record the error
                    Error = Error + "The customer id may not be less than one : ";
                }
                // if customer id is greater than max integer value
                if (Convert.ToInt32(CustomerId) > 2147483647)
                {
                    //record the error
                    Error = Error + "The customer id may not be greater than 2,147,483,647 : ";
                }
            }
            catch
            {
                Error = Error + "The customer id was not an integer : ";

            }
            // try catch for if the data type isn't an integer
            try
            {
                // if staff id is less than one
                if (Convert.ToInt32(StaffId) < 1)
                {
                    //record the error
                    Error = Error + "The customer id may not be less than one : ";
                }
                // if staff id is greater than max integer value
                if (Convert.ToInt32(StaffId) > 2147483647)
                {
                    //record the error
                    Error = Error + "The customer id may not be greater than 2,147,483,647 : ";
                }
            }
            catch
            {
                Error = Error + "The staff id was not an integer : ";

            }

            //return any error messages
            return Error;
        }
    }
}