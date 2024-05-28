using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();

        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                return StaffList.Count;
            }
            set
            {
                //later
            }
        }
        public clsStaff ThisStaff { get; set; }
        public clsStaffCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("dbo.sproc_tblStaff_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStaff AnStaff = new clsStaff();
                AnStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnStaff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnStaff.Role = Convert.ToString(DB.DataTable.Rows[Index]["Role"]);
                AnStaff.DoB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DoB"]);
                AnStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                mStaffList.Add(AnStaff);
                Index++;
            }
        }
    }

}