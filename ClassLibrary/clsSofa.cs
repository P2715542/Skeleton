using System;
using System.Configuration;

namespace ClassLibrary
{
    public class clsSofa
    {
    

        public bool Find(int sofaId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SofaId", sofaId);
            DB.Execute("sproc_tblSofa_FilterBySofaId");
            if (DB.Count == 1)
            {
                mSofaId = Convert.ToInt32(DB.DataTable.Rows[0]["SofaId"]);
                mSofaDescription = Convert.ToString(DB.DataTable.Rows[0]["SofaDescription"]);
                mSofaColour = Convert.ToString(DB.DataTable.Rows[0]["SofaColour"]);
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                return true;
            }
            else
            {
                return false;
            }
     
        }
        private Int32 mSofaId;
        private string mSofaDescription;
        private string mSofaColour;
        private Int32 mSupplierId;
        private decimal mPrice;
        private bool mAvailable;
        private DateTime mDateAdded;

        public Int32 SofaId
        {
            get
            {
                return mSofaId;
            }
            set
            {
                mSofaId = value;
            }
        }

        public string SofaDescription
        {
            get
            {
                return mSofaDescription;
            }
            set
            {
                mSofaDescription = value;
            }
        }

        public string Colour
        {
            get
            {
                return mSofaColour;
            }
            set
            {
                mSofaColour = value;
            }
        }

        public Int32 SupplierId
        {
            get
            {
                return mSupplierId;
            }
            set
            {
                mSupplierId = value;
            }
        }

        public decimal Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }

        public bool Available
        {
            get
            {
                return mAvailable;
            }
            set
            {
                mAvailable = value;
            }
        }

        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }

        public string Valid(string sofaDescription, string sofaColour, string supplierId, string price, string dateAdded)
        {
            String Error = "";
            DateTime DateTemp;
            if (sofaDescription.Length == 0)
            {
                Error = Error + "The sofa description may not be left blank : ";
            }

            if (sofaDescription.Length > 50)
            {
                Error = Error + "The sofa description must be less than 50 characters";
            }

            try
            {
                if (Convert.ToInt32(supplierId) < 1)
                {
                    Error = Error +  "The supplier id is not long enough : ";
                }

                if (Convert.ToInt32(supplierId) > 2147483647)
                {
                    Error = Error + "The supplier id is too long : ";
                }
            }
            catch
            {
                Error = Error + "This supplier id is not valid : ";
            }
           
            try
            {
                if (Convert.ToDecimal(price) < 0)
                {
                    Error = Error + "The price is not high enough : ";
                }

                if (Convert.ToDecimal(price) > 10000)
                {
                    Error = Error + "The price is too high : ";
                }
            }
            catch
            {
                Error = Error + "The price is not a valid price : ";
            }

            if (sofaColour.Length == 0)
            {
                Error = Error + "The sofa colour may not be left blank : ";
            }

            if (sofaColour.Length > 50)
            {
                Error = Error + "The sofa colour must be less than 50 characters";
            }

            try
            {
                DateTemp = Convert.ToDateTime(dateAdded);
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

            return Error;
        }
    }
}