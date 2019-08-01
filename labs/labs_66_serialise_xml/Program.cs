using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace labs_66_serialise_xml
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Customer(12345, "Ovie", "12 Peckham Rye", "WX123401B");

            //XML Serialise into a file stream
            var formatter = new SoapFormatter();
            using (var filestream = new FileStream("data.xml",FileMode.Create, FileAccess.Write, FileShare.None))
            {
                //send data to file stream
                formatter.Serialize(filestream, c1);
            }
            Console.WriteLine(File.ReadAllText("data.xml"));

            //imagine on another computer: can we reconstruct instance

            Customer customerFromXML;
            using(var streamreader = File.OpenRead("data.xml"))
            {
                //deserialize back into instance of class
                customerFromXML = formatter.Deserialize(streamreader) as Customer;
            }
            Console.WriteLine($"Reconstructed customer: {customerFromXML.CustomerID}" + " " + $"{customerFromXML.CustomerName}{customerFromXML.Address}");
            Console.WriteLine($"NINO is blank!! {customerFromXML.GetNINO()}");
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
