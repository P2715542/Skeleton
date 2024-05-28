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
            TestItem.Role= "Service";
            TestItem.DoB = DateTime.Parse("01/01/2020");
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
        [TestMethod]
        public void ThisCustomerPropertyOK()
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
    }
}
