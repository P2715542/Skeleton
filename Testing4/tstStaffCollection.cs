using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing4
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }
        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            // in this case the data need to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an Item to the List
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Active = true;
            TestItem.StaffId = 1;
            TestItem.FirstName = "Test";
            TestItem.LastName = "Man";
            TestItem.Email = "TestMan@gmail.com";
            TestItem.Role = "Service";
            TestItem.DoB = DateTime.Parse("01/01/2020");
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.Active = true;
            TestStaff.StaffId = 1;
            TestStaff.FirstName = "Test";
            TestStaff.LastName = "Man";
            TestStaff.Email = "TestMan@gmail.com";
            TestStaff.Role = "Service";
            TestStaff.DoB = DateTime.Parse("01/01/2020");
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            // in this case the data need to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an Item to the List
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Active = true;
            TestItem.StaffId = 1;
            TestItem.FirstName = "Test";
            TestItem.LastName = "Man";
            TestItem.Email = "TestMan@gmail.com";
            TestItem.Role = "Service";
            TestItem.DoB = DateTime.Parse("01/01/2020");
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //vairable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.StaffId = 1;
            TestItem.FirstName = "Test";
            TestItem.LastName = "Man";
            TestItem.Email = "TestMan@gmail.com";
            TestItem.Role = "Service";
            TestItem.DoB = DateTime.Parse("01/01/2020");
            //set ThisCustomer to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.StaffId = 1;
            TestItem.FirstName = "Test";
            TestItem.LastName = "Man";
            TestItem.Email = "TestMan@gmail.com";
            TestItem.Role = "Service";
            TestItem.DoB = DateTime.Parse("01/01/2020");
            //set ThisCustomer to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //modify the test record
            TestItem.Active = false;
            TestItem.StaffId = 3;
            TestItem.FirstName = "Update";
            TestItem.LastName = "Test";
            TestItem.Email = "UpdateTest@gmail.com";
            TestItem.Role = "UpdateService";
            TestItem.DoB = DateTime.Now.Date;
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see if ThisStaff matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.StaffId = 7;
            TestItem.FirstName = "Test";
            TestItem.LastName = "Man";
            TestItem.Email = "TestMan@gmail.com";
            TestItem.Role = "Service";
            TestItem.DoB = DateTime.Parse("01/01/2020");

            //set ThisCustomer to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByLastNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (should return all record)
            FilteredStaff.ReportByLastName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }
        [TestMethod]
        public void ReportByLastNameNoneFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReportByLastName("xxxxxx");
            Assert.AreEqual(0, FilteredStaff.Count);
        }
        [TestMethod]
        public void ReportByLastNameTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a last name that doesn't exist
            FilteredStaff.ReportByLastName("woodkei");
            //check that the correct number of records are found
            if (FilteredStaff.Count == 2)
            {
                //check to see that the first record is 25
                if (FilteredStaff.StaffList[0].StaffId != 25)
                {
                    OK = false;
                }
                //check to see that the first record is 26
                if (FilteredStaff.StaffList[1].StaffId != 26)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
        }
    }
}
