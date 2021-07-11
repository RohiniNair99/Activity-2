using Microsoft.VisualStudio.TestTools.UnitTesting;
using Activity2BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity2BL.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        [TestMethod()]
        public void PCustomerTest()
        {
            Customer obj1 = new Customer();
            int expected1 = 1000;
            int actual1 = obj1.CustomerId;
            Customer obj2 = new Customer();
            int expected2 = 1001;
            int actual2 = obj2.CustomerId;
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);

        }

        [TestMethod()]
        public void NCustomerTest()
        {
            Customer obj1 = new Customer();
            Customer obj2 = new Customer();
            int expected2 = 1000;
            int actual2 = obj2.CustomerId;
            Assert.AreNotEqual(expected2, actual2);

        }

        [TestMethod()]
        public void CustomerTest()
        {
            Gender gen = new Gender("Female");
            Customer customer = new Customer("Rohit", "Pune", DateTime.ParseExact("23/03/1999","dd/MM/yyyy",null), "rohit@gmail.com",gen, "rohit123", "Gold");
            string expname = "Rohit";
            string exploc = "Pune";
            DateTime expdate = DateTime.ParseExact("23/03/1999", "dd/MM/yyyy", null);
            string expmail = "rohit@gmail.com";
            string expGender = "Female";
            string actualname = customer.CustomerName;
            string actualloc = customer.Address;
            DateTime actualDate = customer.DateOfBirth;
            string actualMail = customer.EmailId;
            string actualGender = gen.gender;
            Assert.AreEqual(expname, actualname);
            Assert.AreEqual(exploc, actualloc);
            Assert.AreEqual(expdate, actualDate);
            Assert.AreEqual(expmail, actualMail);
            Assert.AreEqual(expGender, actualGender);
        }
    }
}