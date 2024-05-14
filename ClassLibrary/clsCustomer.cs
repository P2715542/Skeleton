using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data members for each property
        private int mCustomerID;
        private string mFirstName;
        private string mLastName;
        private string mEmail;
        private string mPhoneNumber;
        private DateTime mDateOfBirth;
        private Boolean mActive;


        //CustomerID public property
        public int CustomerID
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerID;
            }
            set
            {
                //this line of code allows the data into the property
                mCustomerID = value;
            }
        }

        //FirstName public property
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

        //LastName public property
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

        //Email public property
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

        //PhoneNumber public property
        public string PhoneNumber
        {
            get
            {
                //this line of code sends data out of the property
                return mPhoneNumber;
            }
            set
            {
                //this line of code allows data into the property
                mPhoneNumber = value;
            }
        }

        //DateTime public property
        public DateTime DateOfBirth
        {
            get
            {
                //this line of code sends data out of the property
                return mDateOfBirth;
            }
            set
            {
                //this line of code allows the data into the property
                mDateOfBirth = value;
            }
        }

        //Active public property
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
        public bool Find(int CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }

        public string Valid(string firstName, string lastName, string email, string phoneNumber, string dateOfBirth)
        {
            //create a string variable to store the error
            String Error = "";

            //create a temporary variable to store the data values
            DateTime DateTemp;


            //if the firstName is blank
            if (firstName.Length == 0)
            {
                //record the error
                Error = Error + "The first name may not be blank : ";
            }
            //if the first name is greater than 50 characters
            if (firstName.Length > 50)
            {
                //record the error
                Error = Error + "The first name must be less than 50 characters : ";
            }


            //is the last name blank
            if (lastName.Length == 0)
            {
                //record the error
                Error = Error + "The last name may not be blank : ";
            }
            //if the last name is too long
            if (lastName.Length > 50)
            {
                //record the error
                Error = Error + "The last name must be less than 50 characters : ";
            }


            //if the email is blank
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "The email may not be blank : ";
            }
            //if the email is greater than 100 characters
            if (email.Length > 100)
            {
                //record the error
                Error = Error + "The email must be less than 100 characters : ";
            }


            //if the phoneNumber is blank
            if (phoneNumber.Length == 0)
            {
                //record the error
                Error = Error + "The phone number may not be blank : ";
            }
            //if the phone number is greater than 15 characters
            if (phoneNumber.Length > 15)
            {
                //record the error
                Error = Error + "The phone number must be less than 15 numbers : ";
            }


            DateTime DateComp = DateTime.Now.Date;
            try
            {
                //copy the dateOfBirth value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateOfBirth);

                if (DateTemp < DateComp) //compare dateOfBirth with Date
                {
                    //record the error
                    Error = Error + "The date cannot be in the future: ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future: ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date: ";
            }


            //return any error messages
            return Error;
        }
    }
}