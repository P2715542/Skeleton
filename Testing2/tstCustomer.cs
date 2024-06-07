using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass the method
        string FirstName = "John";
        string LastName = "Smith";
        string Email = "johnsmith@gmail.com";
        string Password = "j0hnsm1th";
        string AccountCreated = DateTime.Parse("23/05/2024").ToShortDateString();


        /******************INSTANCE OF THE CLASS TEST******************/
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
        }


        /******************PROPERTY OK TESTS******************/
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnCustomer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Active, TestData);
        }

        [TestMethod]
        public void AccountCreatedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnCustomer.AccountCreated = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.AccountCreated, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "h4rrysm1th";
            //assign the data to the property
            AnCustomer.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Password, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "harrysmith@gmail.com";
            //assign the data to the property
            AnCustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Email, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Harry";
            //assign the data to the property
            AnCustomer.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Smith";
            //assign the data to the property
            AnCustomer.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.LastName, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AnCustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerID, TestData);
        }


        /******************FIND METHOD TEST******************/
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            int CustomerID = 6;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }


        /******************PROPERTY DATA TESTS******************/
        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerID = 6;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the address id
            if (AnCustomer.CustomerID != 6)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 6;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the town property
            if (AnCustomer.FirstName != "Test")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 6;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the town property
            if (AnCustomer.LastName != "Man")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 6;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the town property
            if (AnCustomer.Email != "testman@test.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPasswordFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 6;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the town property
            if (AnCustomer.Password != "manT3st")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAccountCreatedFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerID = 6;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the AccountCreated property
            if (AnCustomer.AccountCreated != Convert.ToDateTime("10/05/2024"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 6;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the Active property
            if (AnCustomer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        /******************VALIDATION (MIDDLE LAYER)******************/
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variables to store any error message
            String Error = "";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string FirstName = "";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "a";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "aa";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String FirstName = "";
            FirstName = FirstName.PadRight(49, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(50, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string FirstName = "";
            FirstName = FirstName.PadRight(51, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(25, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variables to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            FirstName = FirstName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string LastName = "";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "a";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "aa";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String LastName = "";
            LastName = LastName.PadRight(49, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "";
            LastName = LastName.PadRight(50, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string LastName = "";
            LastName = LastName.PadRight(51, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "";
            LastName = LastName.PadRight(25, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variables to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Email = "";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "a";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "aa";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Email = "";
            Email = Email.PadRight(99, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(100, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string Email = "";
            Email = Email.PadRight(101, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(50, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variables to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(1000, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Password = "";
            Password = Password.PadRight(6, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Password = "";
            Password = Password.PadRight(7, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Password = "";
            Password = Password.PadRight(8, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Password = "";
            Password = Password.PadRight(49, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Password = "";
            Password = Password.PadRight(50, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string Password = "";
            Password = Password.PadRight(51, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Password = "";
            Password = Password.PadRight(22, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variables to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void AccountCreatedExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variables to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //change the data to whatever the date is less 200 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string AccountCreated = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreatedMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variables to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Parse("01/05/2024");
            //change the data to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string AccountCreated = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreatedMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variables to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to today's date
            TestDate = DateTime.Parse("01/05/2024");
            //convert the date variable to a string variable
            string AccountCreated = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreatedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variables to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to may 1st
            TestDate = DateTime.Parse("01/05/2024");
            //change the data to whatever the date is less 100 years
            TestDate = TestDate.AddDays(+1);
            //convert the date variable to a string variable
            string AccountCreated = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreatedMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variables to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to today's date
            TestDate = DateTime.Now.Date;
            //change the date to yesterday's date
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string AccountCreated = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreatedMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variables to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string AccountCreated = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreatedMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variables to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to today's date
            TestDate = DateTime.Now.Date;
            //change the date to tommorow's date
            TestDate = TestDate.AddDays(+1);
            //convert the date variable to a string variable
            string AccountCreated = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreatedExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variables to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddYears(+100);
            //convert the date variable to a string variable
            string AccountCreated = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreatedInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variables to store any error message
            String Error = "";
            //set the AccountCreated to a non date value
            string AccountCreated = "this is not a date!";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Email, Password, AccountCreated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
