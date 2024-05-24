using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            // in this case the data need to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an Item to the List
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Test";
            TestItem.LastName = "Man";
            TestItem.Email = "TestMan@gmail.com";
            TestItem.Password = "manT3st";
            TestItem.AccountCreated = DateTime.Parse("10/05/2024");
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.Active = true;
            TestCustomer.CustomerID = 1;
            TestCustomer.FirstName = "Test";
            TestCustomer.LastName = "Man";
            TestCustomer.Email = "TestMan@gmail.com";
            TestCustomer.Password = "manT3st";
            TestCustomer.AccountCreated = DateTime.Parse("10/05/2024");
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            // in this case the data need to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an Item to the List
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Test";
            TestItem.LastName = "Man";
            TestItem.Email = "TestMan@gmail.com";
            TestItem.Password = "manT3st";
            TestItem.AccountCreated = DateTime.Parse("10/05/2024");
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //vairable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Test";
            TestItem.LastName = "Man";
            TestItem.Email = "TestMan@gmail.com";
            TestItem.Password = "manT3st";
            TestItem.AccountCreated = DateTime.Parse("10/05/2024");
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Test";
            TestItem.LastName = "Man";
            TestItem.Email = "TestMan@gmail.com";
            TestItem.Password = "manT3st";
            TestItem.AccountCreated = DateTime.Parse("10/05/2024");
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the test record
            TestItem.Active = false;
            TestItem.CustomerID = 3;
            TestItem.FirstName = "Update";
            TestItem.LastName = "Test";
            TestItem.Email = "UpdateTest@gmail.com";
            TestItem.Password = "07123451234";
            TestItem.AccountCreated = DateTime.Now.Date;
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see if ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Test";
            TestItem.LastName = "Man";
            TestItem.Email = "TestMan@gmail.com";
            TestItem.Password = "manT3st";
            TestItem.AccountCreated = DateTime.Parse("10/05/2024");
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByLastNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all record)
            FilteredCustomers.ReportByLastName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByLastNameTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a last name that doesn't exist
            FilteredCustomers.ReportByLastName("Angle");
            //check that the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {
                //check to see that the first record is 25
                if (FilteredCustomers.CustomerList[0].CustomerID != 74)
                {
                    OK = false;
                }
                //check to see that the first record is 26
                if (FilteredCustomers.CustomerList[1].CustomerID != 75)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }

    }
}