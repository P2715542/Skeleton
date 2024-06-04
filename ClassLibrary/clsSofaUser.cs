using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace ClassLibrary
{
    public class clsSofaUser
    {
        private Int32 mUserID;
        private string mUserName;
        private string mPassword;
        private string mDepartment;
        



        public int UserId
        {
            get
            {
                return mUserID;
            }


            set
            {
                mUserID = value;
            }
        }


        public string UserName
        {
            get
            {
                return mUserName;
            }


            set
            {
                mUserName = value;
            }
        }
        public string Password
        {
            get
            {
                return mPassword;
            }


            set
            {
                mPassword = value;
            }
        }
        public string Department
        {
            get
            {
                return mDepartment;
            }


            set
            {
                mDepartment = value;
            }
        }

        public bool FindUser(string username, string password)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserName", username);
            DB.AddParameter("@Password", password);
            DB.Execute("sproc_tblUsers_FindUserNamePW");
            if (DB.Count == 1)
            {
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserId"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    }

