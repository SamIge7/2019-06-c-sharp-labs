using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Exercise
{
    class Program
    {
        static List<Customer> customers;
        static List<Product> products;
        static List<Order> orders;
        static List<Order_Detail> orderdetails;
        static List<Category> categories;
        static List<Supplier> suppliers;
        static void Main(string[] args)
        {
            using (var db = new NorthwindEntities())
            {
                //SQL Practice Exercise

                // 1.1	Write a query that lists all Customers in either Paris or London. Include Customer ID, Company Name and all address fields.
                Console.WriteLine("\n=====1.1======\n");
                var output01 = db.Customers.Where(c => c.City == "London" || c.City == "Paris");
                foreach (var c in output01)
                {
                    Console.WriteLine($"{c.CustomerID,-5}, {c.ContactTitle,-15}, {c.ContactName,-10}, {c.City}");
                }

                // 1.2	List all products stored in bottles.
                Console.WriteLine("\n=====1.2=====\n");
                var output02 = db.Products.Where(p => p.QuantityPerUnit.Contains("bottle"));
                foreach(var p in output02)
                {
                    Console.WriteLine($"{p.ProductName, -5}, {p.QuantityPerUnit}");
                }

                // 1.3	Repeat question above, but add in the Supplier Name and Country.
                Console.WriteLine("\n=====1.3=====\n");
                var output03 = from p in products
                               join s in suppliers
                               on p.SupplierID equals s.SupplierID;
                foreach (var ps in output03)
                { 
                   Console.WriteLine($"{ps.ProductName,-5}, {ps.QuantityPerUnit,-5}, {ps.CompanyName,-5}, {ps.Country}");
                }
                Console.ReadLine();
            }




        }
    }
}
