using System;
using System.Data.Common;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the address id property
        private int mStaffId;
        //addressId public property
        public int StaffId
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffId;
            }
            set
            {
                //this line of code allows data into the property
                mStaffId = value;
            }
        }
        //private data member for the house no property
        private string mFirstName;
        //house no public property
        public string FirstName
        {
            get
            {
                //this line of code sends data out of the property
                return mFirstName;
            }
            set
            {
                //this line of code allows data into the property
                mFirstName = value;
            }
        }
        //private data member for the street property
        private string mLastName;
        //street public property
        public string LastName
        {
            get
            {
                //this line of code sends data out of the property
                return mLastName;
            }
            set
            {
                //this line of code allows data into the property
                mLastName = value;
            }
        }
        //private data member for the town property
        private string mEmail;
        //town public property
        public string Email
        {
            get
            {
                //this line of code sends data out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property
                mEmail = value;
            }
        }
        //private data member for the post code property
        private string mRole;
        //post code public property
        public string Role
        {
            get
            {
                //this line of code sends data out of the property
                return mRole;
            }
            set
            {
                //this line of code allows data into the property
                mRole = value;
            }
        }
        //private data member for the date added property
        private DateTime mDoB;
        //date added public property
        public DateTime DoB
        {
            get
            {
                //this line of code sends data out of the property
                return mDoB;
            }
            set
            {
                //this line of code allows data into the property
                mDoB = value;
            }
        }
        //private data member for the active property
        private Boolean mActive;
        //active public property
        public bool Active
        {
            get
            {
                //this line of code sends data out of the property
                return mActive;
            }
            set
            {
                //this line of code allows data into the property
                mActive = value;
            }
        }
        /****** FIND METHOD ******/
        public bool Find(int StaffId)
        {
            clsDataConnection DB = new clsDataConnection();
            //add parameters
            DB.AddParameter("@StaffId", StaffId);
            //execute
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            if (DB.Count == 1)
            {
                //set the private data members to the test data value
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]); 
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]); 
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]); 
                mRole = Convert.ToString(DB.DataTable.Rows[0]["Role"]); 
                mDoB = Convert.ToDateTime(DB.DataTable.Rows[0]["DoB"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //always return true
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string firstName, string lastName, string email, string role, string doB)
        {
            String Error = "";

            //create a temporary variable to store the data values
            DateTime DateTemp;

            if (firstName.Length == 0)
            {
                //record the error
                Error = Error + "The First Name may not be BLANK. ";
            }
            //if the first name is greater than 50 characters
            if (firstName.Length > 50)
            {
                //record the error
                Error = Error + "The first name must be less than 50 characters. ";
            }
            //is the last name blank
            if (lastName.Length == 0)
            {
                //record the error
                Error = Error + "The last name may not be BLANK. ";
            }
            //if the last name is too long
            if (lastName.Length > 50)
            {
                //record the error
                Error = Error + "The last name must be less than 50 characters. ";
            }
            //if the email is blank
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "The email may not be BLANK. ";
            }
            //if the email is greater than 100 characters
            if (email.Length > 100)
            {
                //record the error
                Error = Error + "The email must be less than 100 characters. ";
            }
            //if the role is blank
            if (role.Length == 0)
            {
                //record the error
                Error = Error + "The role may not be BLANK. ";
            }
            //if the role is greater than 100 characters
            if (role.Length > 50)
            {
                //record the error
                Error = Error + "The role must be less than 100 characters : ";
            }
            //create an instance of DateTime to compare with DateTemp
            DateTime DateComp1 = DateTime.Parse("01/01/2020");
            DateTime DateComp2 = DateTime.Now.Date;
            try
            {
                //copy the AccountCreated value to the DateTemp variable
                DateTemp = Convert.ToDateTime(doB);

                if (DateTemp > DateComp1) //compare DoB with May 1st
                {
                    //record the error
                    Error = Error + "The date cannot be after that date. ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateComp2)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future. ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date. ";
            }
            //return error message
            return Error;
        }
    }
}

   