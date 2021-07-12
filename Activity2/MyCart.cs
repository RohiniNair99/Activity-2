using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activity2BL;

namespace Activity2
{
    class MyCart
    {
        static void Main(string[] args)
        {
            string customerName = "";
            string address = "", emailId = "", password = "", customerType = "";
            DateTime dateOfBirth = new DateTime();
            Gender g = new Gender("");
            string productName = "", description = "";
            double price = 0.0D;
            string  sellerName = "";
            int quantityOrdered = 0;
            DateTime dateOfPurchase=new DateTime();
            string paymentType="Regular";
            string[] sellerLoc = new string[30];

            try
            {
                Console.WriteLine("Enter Customer Name:");
                customerName = Console.ReadLine();
                if (customerName == null)
                    throw new ArgumentException();
                if (customerName != null)
                    foreach (char ch in customerName)
                    {
                        if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') || (ch == ' '))
                            continue;
                        else
                            throw new ArgumentException();
                    }
                Console.WriteLine("Enter Customer Address:");
                address = Console.ReadLine();
                if (address == null)
                    throw new ArgumentException();

                Console.WriteLine("Enter Customer Type:");
                customerType = Console.ReadLine();
                if (customerType == null)
                    throw new ArgumentException();
                if (customerType != null)
                    foreach (char ch in customerType)
                    {
                        if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
                            continue;
                        else
                            throw new ArgumentException();
                    }
                Console.WriteLine("Enter Password:");
                password = Console.ReadLine();
                if (password == null && password.GetType() != typeof(string))
                    throw new ArgumentException();

                Console.WriteLine("Enter PaymentType:");
                paymentType = Console.ReadLine();
                if (paymentType == null && paymentType.GetType() != typeof(string))
                    throw new ArgumentException();

                Console.WriteLine("Enter Date Of Birth:");
                dateOfBirth = DateTime.ParseExact(Console.ReadLine(), "dd/mm/yyyy", null);
                if (dateOfBirth.GetType() != typeof(DateTime))
                    throw new ArgumentException();
                Console.WriteLine("Enter the gender:");
                g.gender = Console.ReadLine();

                Console.WriteLine("Enter Product Name:");
                productName = Console.ReadLine();
                if (productName == null)
                    throw new ArgumentException();
                if (productName != null)
                    foreach (char ch in productName)
                    {
                        if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') || (ch == ' '))
                            continue;
                        else
                            throw new ArgumentException();
                    }

                Console.WriteLine("Enter Product Description:");
                description = Console.ReadLine();
                if (description == null)
                    throw new ArgumentException();
                if (description != null)
                    foreach (char ch in description)
                    {
                        if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') || (ch == ' '))
                            continue;
                        else
                            throw new ArgumentException();
                    }
                Console.WriteLine("Enter Price:");
                price = Convert.ToDouble(Console.ReadLine());
                if (price.GetType() != typeof(double))
                    throw new ArgumentException();

                Console.WriteLine("Enter Purchase Date:");
                dateOfPurchase = DateTime.ParseExact(Console.ReadLine(), "dd/mm/yyyy", null);
                if (dateOfPurchase.GetType() != typeof(DateTime))
                    throw new ArgumentException();

                Console.WriteLine("Enter Seller Name:");
                sellerName = Console.ReadLine();
                if (sellerName == null)
                    throw new ArgumentException();
                if (sellerName != null)
                    foreach (char ch in sellerName)
                    {
                        if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') || (ch == ' '))
                            continue;
                        else
                            throw new ArgumentException();
                    }
              /*  Console.WriteLine("Enter Seller ID:");
                sellerId = Console.ReadLine();
                if (sellerId == null )
                    throw new ArgumentException();*/

                Console.WriteLine("Enter number of locations seller available:");
                int numloc = Convert.ToInt32(Console.ReadLine());
                if (numloc.GetType() != typeof(int))
                    throw new ArgumentException();
                for (int index = 0; index < numloc; index++)
                {
                    Console.WriteLine($"Enter Location {index + 1}: ");
                    sellerLoc[index] = Console.ReadLine();
                }


               /* sellerId = Console.ReadLine();
                if (sellerId == null && sellerId.GetType() != typeof(string))
                    throw new ArgumentException();*/

                Console.WriteLine("Enter Quantity Entered:");
                quantityOrdered = Convert.ToInt32(Console.ReadLine());
                if (quantityOrdered.GetType() != typeof(int))
                    throw new ArgumentException();

                Customer customer = new Customer(customerName, address, dateOfBirth, emailId, g, password, customerType);
                Product product = new Product(productName, description, price);
                Purchase purchase = new Purchase(quantityOrdered, address, dateOfPurchase, paymentType);
                Seller seller = new Seller(sellerName);
                seller.SellerLocations = sellerLoc;

                Console.WriteLine($"\n\nCustomer details:\n \nCustomer Name: {customer.CustomerName} \nCustomer Id: {customer.CustomerId} \nCustomer Address: {customer.Address} \nDate of Birth: {customer.DateOfBirth} \nEmail Id: {customer.EmailId} \nGender: {g.gender} \nPassword: {customer.Password} \nCustomer Type: {customer.CustomerType}");
                Console.WriteLine($"\n\nSeller details:\n \nSeller Name: {seller.SellerName} \nSeller Id: {seller.SellerId}\nSeller loc:");
                for(int loop=0;loop<seller.SellerLocations.Length;loop++)
                {
                    Console.WriteLine($"Location{loop+1}:{seller.SellerLocations[loop]}");
                }
                Console.WriteLine($"\n\nProduct details:\n\nProduct Name: {product.ProductName} \nProduct Id: {product.ProductId} \nProduct Description: {product.Description} \nPrice: {product.Price} ");
                Console.WriteLine($"\n\n Purchase details: \n\nPurchase Id: {purchase.PurchaseId} \nShipping Address: {purchase.ShippingAddress} \nPurchase Date: {purchase.DateOfPurchase} \nPurchase quantity : {purchase.QuantityOrdered} \nPayment Type: {purchase.PaymentType} \nBill Amount: {purchase.CalculateBillAmount(price)} \nRounded off Amount: {Purchase.RoundOffBill(purchase.CalculateBillAmount(price))}");

            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid Entry:");
            }

            finally
            {
                Console.ReadLine();
                System.Environment.Exit(1000);
            }

            
               
            


        }
    }
}
