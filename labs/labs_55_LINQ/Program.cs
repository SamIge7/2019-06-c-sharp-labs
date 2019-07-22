using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs_55_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers;
            List<Product> products;
            List<Order> orders;
            List<Order_Detail> orderdetails;
            List<Category> categories;
            using (var db = new NorthwindEntities())
            {
                

                //snap lab
                //1) how many customers?
                var output1 = from customer in db.Customers
                              select customer;
                int counter = 0;
                foreach (var v1 in output1)
                {
                    counter ++;
                }
                Console.WriteLine(counter);
                //2) how many products?
                var output2 = from product in db.Products
                              select product;
                int counter2 = 0;
                foreach (var v2 in output2)
                {
                    counter2++;
                }
                Console.WriteLine(counter2);
                //3) how many orders?
                var output3 = from order in db.Orders
                              select order;
                int counter3 = 0;
                foreach (var v3 in output3)
                {
                    counter3++;
                }
                Console.WriteLine(counter3);
                //4) can we print the average order value? (order_details)?
                var output4 = from orderdetail in db.Order_Details
                              select orderdetail;
                int counter4 = 0;
                decimal total = 0;
                foreach(var v4 in output4)
                {
                    counter4++;
                    total += ((v4.UnitPrice * v4.Quantity) * (decimal)(1 - v4.Discount));
                    
                }
                var average = total / counter4;
                Console.WriteLine(average);
                

                //amazing way to join 2 tables using 'dot' notation
                //look at products and categories
                //goal: list categories in order and for each category 1) count products and 2) list individual product names
                Console.WriteLine("\n\n=============Categories============\n\n");
                categories = db.Categories.ToList();
                products = db.Products.ToList();
                foreach (var c in categories)
                {
                    Console.WriteLine($"\n\t{c.CategoryID}) {c.CategoryName, -15} has {c.Products.Count} products\n");
                    Console.WriteLine("\t\t=========Products===========");
                    foreach (var p in c.Products)
                    {
                        Console.WriteLine($"\t\t{p.ProductID} is {p.ProductName}");
                    }
                }

                
            }
        }
    }
}
