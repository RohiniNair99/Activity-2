using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity2BL
{
   public class Gender
    {
        public string gender;
        
        public Gender(string gender)
        {
            this.gender = gender;
        }
    }

   
    public class Customer
    {
        private string address;
        static int currentValueForCustomerId;
        private int customerId;
        private string customerName;
        private string customerType;
        private DateTime dateOfBirth;
        private string emailId;
        private Gender gender;
        private string password;

       public string Address
        {
            get{ return address; }
            set { address = value; }
        }

        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public string CustomerType
        {
            get { return customerType; }
            set { customerType = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string EmailId
        {
            get { return emailId; }
            set { emailId = value; }
        }

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        static Customer()
        {
            currentValueForCustomerId = 1000;
        }

        public Customer()
        {
            customerId = currentValueForCustomerId;
            currentValueForCustomerId++;
        }

        public Customer(string customerName,string address,DateTime dateOfBirth,string emailId,Gender gender,string password,string customerType)
        {
            this.customerName = customerName;
            this.address = address;
            this.dateOfBirth = dateOfBirth;
            this.emailId = emailId;
            this.gender = gender;
            this.password = password;
            this.customerType = customerType;
        }

        public double GetDiscount()
        {
            Console.WriteLine("Enter Discount Percentage: ");
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
