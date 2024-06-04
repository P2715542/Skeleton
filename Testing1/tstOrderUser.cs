using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Dynamic;

namespace Testing1
{
    [TestClass]
    public class tstOrderUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create class instance of class we wish to create
            clsOrderUser AnUser = new clsOrderUser();
            //test to see it exists
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            // create class instance
            clsOrderUser AnUser = new clsOrderUser();
            // create some test data
            Int32 TestData = 1;
            // assign data to property
            AnUser.UserId = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnUser.UserId, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            // Create class instance
            clsOrderUser AnUser = new clsOrderUser();
            // create some test data
            string TestData = "Jake";
            // assign the data to the property
            AnUser.UserName = TestData;
            // test to see the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            // Create class instance
            clsOrderUser AnUser = new clsOrderUser();
            // create some test data
            string TestData = "password123";
            // assign the data to the property
            AnUser.Password = TestData;
            // test to see the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            // Create class instance
            clsOrderUser AnUser = new clsOrderUser();
            // create some test data
            string TestData = "Orders";
            // assign the data to the property
            AnUser.Department = TestData;
            // test to see the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            // create class instance
            clsOrderUser AnUser = new clsOrderUser();
            // create boolean variable to store results of validation
            Boolean Found = false;
            // create some test data to use with the method
            string UserName = "Jake";
            string Password = "password123";
            // invoke the method
            Found = AnUser.FindUser(UserName, Password);
            // test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            // create class instance
            clsOrderUser AnUser = new clsOrderUser();
            // create a boolean variable to store the result of the search
            Boolean Found = false;
            // create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use within the method
            string UserName = "Jake";
            string Password = "password123";
            // invoke the method
            Found = AnUser.FindUser(UserName, Password);
            // check the user is property
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            // test to see if the result is correct
            Assert.IsTrue(OK);
        }
    }
}
