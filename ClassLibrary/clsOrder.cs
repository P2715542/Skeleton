using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Find(int orderId)
        {
            // set the private data members to the test data value
            mOrderId = 2;
            mDateOrdered = Convert.ToDateTime("09/05/2024");
            mOrderName = Convert.ToString("Order Two");
            mSofaId = 2;
            mCustomerId = 1;
            mStaffId = 1;
            mOrderDispatched = false;
            // always return ture
            return true;
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
    }
}