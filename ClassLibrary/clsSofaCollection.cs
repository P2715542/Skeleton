using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class clsSofaCollection
    {
        List<clsSofa> mSofaList = new List<clsSofa>();
        clsSofa mThisSofa = new clsSofa();
        public clsSofaCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblSofa_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsSofa ASofa = new clsSofa();
                ASofa.SofaId = Convert.ToInt32(DB.DataTable.Rows[Index]["SofaId"]);
                ASofa.SofaDescription = Convert.ToString(DB.DataTable.Rows[Index]["SofaDescription"]);
                ASofa.Colour = Convert.ToString(DB.DataTable.Rows[Index]["SofaColour"]);
                ASofa.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                ASofa.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                ASofa.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                ASofa.DateAdded= Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                mSofaList.Add(ASofa);
                Index++;
            }

        }
        public List<clsSofa> SofaList
        {
            get
            {
                return mSofaList;
            }
            set
            {
                mSofaList = value;
            }
        }
        public int Count
        {
            get
            {
                return mSofaList.Count;
            }
            set
            {
                
            }
        }
    
        public clsSofa ThisSofa
        {
            get
            {
                return mThisSofa;
            }
            set
            {
                mThisSofa = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SofaDescription", mThisSofa.SofaDescription);
            DB.AddParameter("@SofaColour", mThisSofa.Colour);
            DB.AddParameter("@SupplierId", mThisSofa.SupplierId);
            DB.AddParameter("@Price", mThisSofa.Price);
            DB.AddParameter("@Available", mThisSofa.Available);
            DB.AddParameter("@DateAdded", mThisSofa.DateAdded);

            return DB.Execute("sproc_tblSofa_Insert");
        }

        public void Update()
        { 
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SofaId", mThisSofa.SofaId);
            DB.AddParameter("@SofaDescription", mThisSofa.SofaDescription);
            DB.AddParameter("@SofaColour", mThisSofa.Colour);
            DB.AddParameter("@SupplierId", mThisSofa.SupplierId);
            DB.AddParameter("@Price", mThisSofa.Price);
            DB.AddParameter("@Available", mThisSofa.Available);
            DB.AddParameter("@DateAdded", mThisSofa.DateAdded);

            DB.Execute("sproc_tblSofa_Update");
        }
    }
}