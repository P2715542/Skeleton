﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStaffUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffUser AnUser = new clsStaffUser();
            Assert.IsNotNull(AnUser);
        }
        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsStaffUser AnUser = new clsStaffUser();
            Int32 TestData = 1;
            AnUser.UserID = TestData;
            Assert.AreEqual(AnUser.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsStaffUser AnUser = new clsStaffUser();
            string TestData = "Maha";
            AnUser.UserName = TestData;
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            //create some test data to assign to the property
            string TestData = "password123";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values
            Assert.AreEqual(AnUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            //create some test data to assign to the property
            string TestData = "Staff";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            string UserName = "Mohammed";
            string Password = "PWextra";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            //create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string UserName = "Mohammed";
            string Password = "PWextra";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //check the user id property
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
