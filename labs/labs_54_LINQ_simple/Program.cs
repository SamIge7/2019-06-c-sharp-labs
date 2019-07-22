using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs_54_LINQ_simple
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();

        static void Main(string[] args)
        {
            using (var db = new NorthwindEntities())
            {
                Console.WriteLine("\n\nAll Customers\n\n");
                var output1 = from customer in db.Customers
                              select customer;

                PrintCustomers(output1.ToList());
                Console.WriteLine("\n\nAll London Customers\n\n");
                var output2 = from c in db.Customers where c.City == "London"
                              select c;

                PrintCustomers(output2.ToList());
                Console.WriteLine("\n\nAll London Customers Descending\n\n");
                var output3 = from c in db.Customers where c.City == "London"
                              orderby c.ContactName descending
                              select c;
                PrintCustomers(output3.ToList());

                Console.WriteLine("\n\nCreating a New Output Object\n\n");
                var output4 = from c in db.Customers
                              orderby c.Country
                              select new
                              {
                                  Name = c.ContactName,
                                  Address = c.City + " " + c.Country
                              };
                foreach(var c in output4)
                {
                    Console.WriteLine($"{c.Name, -20}, {c.Address}");
                }

                Console.WriteLine("\n\nGroup By City\n\n");
                var output5 = from customer in db.Customers
                              group customer by customer.City into Cities
                              orderby Cities.Key
                              select new
                              {
                                  City = Cities.Key,
                                  Count = Cities.Count()
                              };
                foreach(var c in output5)
                {
                    Console.WriteLine($"{c.City, -20}, {c.Count}");
                }

                Console.WriteLine("\n\nSelect Customers and their Orders\n\n");
                var output6 = from customer in db.Customers
                              join order in db.Orders
                              on customer.CustomerID equals order.CustomerID
                              select new
                              {
                                  Name = customer.ContactName,
                                  OrderID = order.OrderID,
                                  OrderDate = order.OrderDate
                              };
                output6.ToList().ForEach(c => Console.WriteLine($"{c.Name,-10}, {c.OrderID,10}, {c.OrderDate}"));
            }
        }

        static void PrintCustomers(List<Customer> customers)
        {
            foreach(var c in customers)
            {
                Console.WriteLine($"{c.CustomerID, -10}, {c.ContactName, -10}, {c.City}");
            }
        }
    }
}
