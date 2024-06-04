using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private member for thisstaff 
        clsStaff mThisStaff = new clsStaff();

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
        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }
        public clsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a record to the data base on the values of mThisStaff
            //set primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            //return the parameters of the new record
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Role", mThisStaff.Role);
            DB.AddParameter("@DoB", mThisStaff.DoB);
            DB.AddParameter("@Active", mThisStaff.Active);

            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            //adds a record to the data base on the values of mThisStaff
            //set primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            //return the parameters of the new record
            DB.AddParameter("@StaffID", mThisStaff.StaffId);
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Role", mThisStaff.Role);
            DB.AddParameter("@DoB", mThisStaff.DoB);
            DB.AddParameter("@Active", mThisStaff.Active);

            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByLastName(string LastName)
        {
            //filters the resords based on lastname
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@LastName", LastName);
            DB.Execute("sproc_tblStaff_FilterByLastName");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of the records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address object
                clsStaff AnStaff = new clsStaff();
                //read in the fields from the current record
                AnStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnStaff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnStaff.Role = Convert.ToString(DB.DataTable.Rows[Index]["Role"]);
                AnStaff.DoB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DoB"]);
                AnStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                //add the record to the private data member
                mStaffList.Add(AnStaff);
                //point at the next record
                Index++;
            }
        }
    }

}