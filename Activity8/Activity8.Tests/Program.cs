using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CSharp.Activity.CoreUtilities;


namespace CSharp.Activity.Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerInfo customerJohn = new CustomerInfo(2,"John Palmer", "Palm Street 10, Los Angeles" , "john@gmail.com");
            Console.WriteLine(customerJohn.Name);
            Console.WriteLine(customerJohn.Email);
            Console.WriteLine(customerJohn.Id);
            Console.WriteLine(customerJohn.Address);

            CustomerInfo customerMary = new CustomerInfo(5, "Mary Oak", "Main Street 2, New York", "mary@hotmail.com");
            CustomerInfo customerBob = new CustomerInfo(12, "Bob Hope", "Queen Street 65, Toronto", "bob@outlook.com");
            CustomerInfo customerTom = new CustomerInfo(15, "Tom Fox", "King Street 10, Washington", "tom@gmail.com");


            CustomerInfoCollection customerInfoCollection = new CustomerInfoCollection();
           
            customerInfoCollection.Insert(0,customerJohn);
            customerInfoCollection.Insert(1, customerJohn);
            customerInfoCollection.Add(customerTom);
            customerInfoCollection.Insert(3, customerMary);
            customerInfoCollection.Insert(4, customerBob);
            customerInfoCollection.Remove(customerJohn);


            foreach (var customerInfo in customerInfoCollection)
            {
                Console.WriteLine(customerInfo.ToString());
            }



            List<CustomerInfo> customers = new List<CustomerInfo>();

            customers.Add(customerJohn);
            customers.Add(customerBob);
            customers.Add(customerMary);
            customers.Add(customerTom);


            foreach(var customer in customers)
            {
                Console.WriteLine(customer.ToString()); 
            }

            string filePath = @"C:\Users\Liene\Desktop\.NET_practical_tasks\Activity8\Activity8\customers.txt";

           
            FileHandling.Writefile(filePath);
            FileHandling.ReadFile(filePath);
                    
                     

            
        }
    }
}
