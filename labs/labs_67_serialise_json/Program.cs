using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Net;

namespace labs_67_serialise_json
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Customer(12345, "Ovie", "12 Peckham Rye", "WX123401B");
            var c2 = new Customer(23456, "Brooklyn", "10 Peckham Road", "WX123401B");
            var c3 = new Customer(34567, "Peralta", "24 Peckham Lane", "WX123401B");
            var customers = new List<Customer>() { c1, c2, c3 };

            var JSONinstance1 = JsonConvert.SerializeObject(c1);
            File.WriteAllText("data.json", JSONinstance1);

            Console.WriteLine(File.ReadAllText("data.json"));

            var customerListAsJSON = JsonConvert.SerializeObject(customers);
            File.WriteAllText("customers.json",customerListAsJSON);

            Console.WriteLine(File.ReadAllText("customers.json"));

            //send data around the world
            //at other end imagine now on a different computer
            //read one customer
            var customerFromJSON = JsonConvert.DeserializeObject<Customer>(File.ReadAllText("data.json"));
            Console.WriteLine($"Reconstructed customer: {customerFromJSON.CustomerID}" + " " + $"{customerFromJSON.CustomerName}," + " " + $"{customerFromJSON.Address}");
            Console.WriteLine($"NINO is blank!! {customerFromJSON.GetNINO()}");

            //read array of customers
            var customerArrayFromJSON = JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText("customers.json"));
            foreach (var c in customerArrayFromJSON)
            {
                Console.WriteLine($"Reconstructed customer: {c.CustomerID}" + " " + $"{c.CustomerName}," + " " + $"{c.Address}");
            }

            GetWebSync();
        }

        static void GetWebSync()
        {
            var downloadWebPage1 = new WebClient { Proxy = null };
            var github = new Uri("https://raw.githubusercontent.com/philanderson888/data/master/customers.json");
            downloadWebPage1.DownloadFile(github, "github.json");
        }
    }


    [Serializable]
    class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        [NonSerialized]
        private string NINO;

        //Constructor
        public Customer(int customerid, string customername, string address, string nino)
        {
            this.Address = address;
            this.CustomerID = customerid;
            this.CustomerName = customername;
            this.NINO = nino;
        }
        public string GetNINO()
        {
            return this.NINO;
        }

    }

   
}
