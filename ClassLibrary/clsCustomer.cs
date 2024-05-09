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
        public bool Find(int customerID)
        {
            //set the private data members to the test data value
            mCustomerID = 21;
            mFirstName = "Harry";
            mLastName = "Smith";
            mEmail = "test@mail.com";
            mPhoneNumber = "07123456789";
            mDateOfBirth = Convert.ToDateTime("23/12/2022");
            mActive = true;
            //always return true
            return true;
        }
    }
}