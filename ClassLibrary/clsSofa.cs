using System;
using System.Configuration;

namespace ClassLibrary
{
    public class clsSofa
    {
    

        public bool Find(int sofaId)
        {
            mSofaId = 1;
            mSofaDescription = "Big";
            mSofaColour = "Blue";
            mSupplierId = 1;
            mPrice = 233;
            mAvailable = true;
            mDateAdded = Convert.ToDateTime("13/09/2023");
            return true;
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
    }
}