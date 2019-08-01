using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace labs_68_serialise_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Customer(12345, "Ovie", "12 Peckham Rye", "WX123401B");
            var c2 = new Customer(23456, "Brooklyn", "10 Peckham Road", "WX123401B");
            var c3 = new Customer(34567, "Peralta", "24 Peckham Lane", "WX123401B");
            var customers = new List<Customer>() { c1, c2, c3 };

            //Performs the serialisation
            var binaryformatter = new BinaryFormatter();

            //stream serialised data to a file in this case but could be web or RAM (Memory)
            using(var binarystream = new FileStream("data.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                //write data to file
                binaryformatter.Serialize(binarystream, customers);
            }

            Console.WriteLine(File.ReadAllText("data.bin"));

            //send data across the world and deserialise at the other end
            var customersFromBinary = new List<Customer>();
            using (var reader = File.OpenRead("data.bin"))
            {
                customersFromBinary = binaryformatter.Deserialize(reader) as List<Customer>;
            }

            //iterate and print out 
            foreach (var c in customers)
            {
                Console.WriteLine($"Reconstructed customer: {c.CustomerID}" + " " + $"{c.CustomerName}," + " " + $"{c.Address}");
            }

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
