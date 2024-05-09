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
    }
}