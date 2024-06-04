using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstSofaUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSofaUser AUser = new clsSofaUser();
            Assert.IsNotNull(AUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsSofaUser User = new clsSofaUser();
            Int32 TestData = 1;
            User.UserId = TestData;
            Assert.AreEqual(User.UserId, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsSofaUser AUser = new clsSofaUser();
            string TestData = "Krish";
            AUser.UserName = TestData;
            Assert.AreEqual(AUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsSofaUser AUser = new clsSofaUser();
            string TestData = "aPassword";
            AUser.Password = TestData;
            Assert.AreEqual(AUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsSofaUser AUser = new clsSofaUser();
            string TestData = "Suppliers";
            AUser.Department = TestData;
            Assert.AreEqual(AUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            clsSofaUser AUser = new clsSofaUser();
            Boolean Found = false;
            string Username = "Krish";
            string Password = "aPassword";
            Found = AUser.FindUser(Username, Password);
            Assert.IsTrue(Found);
        }
        [TestMethod]    
        public void TestUserNamePWFOund()
        {
            clsSofaUser AUser = new clsSofaUser();
            Boolean Found = false;
            Boolean OK = true;
            string UserName = "Krish";
            string Password = "aPassword";
            Found = AUser.FindUser(UserName, Password);
            if (AUser.UserName != UserName && AUser.Password != Password)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }




    }

    
}
