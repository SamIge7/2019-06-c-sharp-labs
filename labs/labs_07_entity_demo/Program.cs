using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs_07_entity_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers;
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList();
            }
            foreach(var customer in customers)
            {
                Console.WriteLine($"{customer.CustomerID,-10}" + $"{customer.ContactName,-30}" + $"{customer.Address,-20}" + $"{customer.City,-50}");
            }
            Console.ReadLine();
        }
    }
}
