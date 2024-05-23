using System;

namespace ClassLibrary
{
    public class clsOrderUser
    {
        // private data member for the user id property
        private Int32 mUserId;
        // private data member for the user name property
        private String mUserName;
        // private data member for the password property
        private String mPassword;
        // private data member for the department property
        private String mDepartment;

        public int UserId {
            get
            {
                // return the private data
                return mUserId;
            }
            set
            {
                // set the private data 
                mUserId = value;
            }
        }
        public string UserName {
            get
            {
                // return the private data
                return mUserName;
            }
            set
            {
                // set the private data 
                mUserName = value;
            }
        }
        public string Password {
            get
            {
                // return the private data
                return mPassword;
            }
            set
            {
                // set the private data 
                mPassword = value;
            }
        }
        public string Department {
            get
            {
                // return the private data
                return mDepartment;
            }
            set
            {
                // set the private data 
                mDepartment = value;
            }
        }

        public bool FindUser(string UserName, string Password)
        {
            // create inatcne of data connection
            clsDataConnection DB = new clsDataConnection();
            // add parameters for the username and password to search for
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@Password", Password);
            // execute the stored procedure
            DB.Execute("sproc_tblUsers_FindUserNamePW");
            // if one record is found (there should be either one or none)
            if (DB.Count == 1)
            {
                // copy the data fromn the database to the private data members
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["UserId"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                // return true to confirm everything worked ok
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}