using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SQL_Exercise_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            List<Product> products = new List<Product>();
            List<Supplier> suppliers = new List<Supplier>();

            var secret = Environment.GetEnvironmentVariable("SamsSecretPassword");
            var connectionstring = $"Data Source=localhost, 1433;User ID=SA;Password={secret};Connect Timeout=30;Initial Catalog=Northwind;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                Console.WriteLine(connection.State);

                //1.1
                Console.WriteLine("=====1.1=====\n");
                using (var command = new SqlCommand("Select CustomerID, CompanyName, ContactName, Address, City, Region, PostalCode, Country From Customers Where City IN ('London', 'Paris')", connection))
                {
                    var sqlreader = command.ExecuteReader();
                    while(sqlreader.Read())
                    {
                        string CustomerID = sqlreader["CustomerID"].ToString();
                        string CompanyName = sqlreader["CompanyName"].ToString();
                        string ContactName = sqlreader["ContactName"].ToString();
                        string Address = sqlreader["Address"].ToString();
                        string City = sqlreader["City"].ToString();
                        string Region = sqlreader["Region"].ToString();
                        string PostalCode = sqlreader["PostalCode"].ToString();
                        string Country = sqlreader["Country"].ToString();
                        var customer = new Customer(CustomerID, ContactName, CompanyName, Address, City, Region, PostalCode, Country);
                        customers.Add(customer);
                    }
                    sqlreader.Close();
                }
                customers.ForEach(c => Console.WriteLine($"{c.CustomerID}, {c.ContactName}, {c.CompanyName}, {c.Address}, {c.City}, {c.Region}, {c.PostalCode}, {c.Country}"));

                //1.2
                Console.WriteLine("\n=====1.2=====\n");
                using (var command = new SqlCommand("SELECT ProductName, QuantityPerUnit FROM Products WHERE QuantityPerUnit LIKE '%bottles%'",connection))
                {
                    var sqlreader = command.ExecuteReader();
                    while(sqlreader.Read())
                    {
                        string ProductName = sqlreader["ProductName"].ToString();
                        string QuantityPerUnit = sqlreader["QuantityPerUnit"].ToString();
                        var product = new Product(ProductName, QuantityPerUnit);
                        products.Add(product);
                    }
                }
                products.ForEach(p => Console.WriteLine($"{p.ProductName}, {p.QuantityPerUnit}"));

                //1.3
                Console.WriteLine("\n=====1.3=====/n");
                using (var command = new SqlCommand("SELECT p.ProductName, p.QuantityPerUnit, s.CompanyName, s.Country FROM Products p INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID WHERE QuantityPerUnit LIKE '%bottles%'", connection))
                {
                    var sqlreader = command.ExecuteReader();
                    while(sqlreader.Read())
                    {
                        string ProductName = sqlreader["ProductName"].ToString();
                        string QuantityPerUnit = sqlreader["QuantityPerUnit"].ToString();
                        string CompanyName = sqlreader["CompanyName"].ToString();
                        string Country = sqlreader["Country"].ToString();
                        
                    }

                }
            }

        }
    }

    class Customer
    {
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public Customer(string customerid, string contactname, string companyname, string address, string city, string region, string postalcode, string country)
        {
            this.CustomerID = customerid;
            this.ContactName = contactname;
            this.CompanyName = companyname;
            this.Address = address;
            this.City = city;
            this.Region = region;
            this.PostalCode = postalcode;
            this.Country = country;
        }
    }

    class Product
    {
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public Product(string productname, string quantityperunit)
        {
            this.ProductName = productname;
            this.QuantityPerUnit = quantityperunit;
        }
    }

    class Supplier
    {
        public string SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }

        public Supplier(string supplierid, string companyname, string country)
        {
            this.SupplierID = supplierid;
            this.CompanyName = companyname;
            this.Country = country;
        }
    }
}
