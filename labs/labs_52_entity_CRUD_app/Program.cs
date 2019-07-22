using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs_52_entity_CRUD_app
{
    class Program
    {
        static List<Customer> customers;
        static Customer customer;
        static void Main(string[] args)
        {
            AddToDatabase();
            UpdateDatabase();
            DeleteFromDatabase();
           
        }

        static void AddToDatabase()
        {
            Console.WriteLine("\n\nAdding New Customer \n============\n\n");

            //new customer
            var newCustomer = new Customer()
            {
                ContactName = "Sam Ige",
                CompanyName = "Sparta",
                ContactTitle = "Mr",
                CustomerID = "SAMLE",
                City = "London",
                Country = "England"
            };

            /*var newCustomer2 = new Customer()
            {
                ContactName = "Sam Ige",
                CompanyName = "Sparta",
                ContactTitle = "Mr",
                CustomerID = "SMALG",
                City = "London",
                Country = "England"
            };*/

            //add to db
            using (var db = new NorthwindEntities())
            {
                db.Customers.Add(newCustomer);
                //db.Customers.Add(newCustomer2);
                int affected = db.SaveChanges();
                Console.WriteLine($"Added {affected} Records");
            }
        }

        static void UpdateDatabase()
        {

            Console.WriteLine("\n\nUpdating New Customer\n============\n\n");

            //update db
            using (var db = new NorthwindEntities())
            {
                var updateCustomer = db.Customers.Find("SAMLE");
                updateCustomer.CompanyName = "Momentum";
                int affected = db.SaveChanges();
                Console.WriteLine($"{affected} records updated");
                ListAll(db.Customers.ToList());
            }

            
        }

        static void DeleteFromDatabase()
        {
            Console.WriteLine("\n\nDeleting New Customer \n============\n\n");

            //delete from db

            using (var db = new NorthwindEntities())
            {
                var deleteCustomer = db.Customers.Find("SAMLE");
                db.Customers.Remove(deleteCustomer);
                int affected = db.SaveChanges();
                Console.WriteLine($"{affected} records removed");
                ListAll(db.Customers.ToList());
            }

            Console.ReadLine();

        }

        static void ListAll(List<Customer> customerslist)
        {
           foreach (var item in customerslist)
            {
                Console.WriteLine($"{item.ContactName, -5}, {item.CompanyName, -5}, {item.CustomerID}");
            }
            
        }
    }
}
