using System;
using System.Xml.Linq;
using System.IO;
using System.Linq;
using Grpc.Core;

namespace labs_69_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nFirst XML Example\n");
            var xml1 = new XElement("testData", 1);
            Console.WriteLine(xml1);

            Console.WriteLine("\nAdd A Sub-Element\n");
            var xml2 = new XElement("XMLRoot",
                        new XElement("XMLData", 100));
            Console.WriteLine(xml2);


            Console.WriteLine("\nSave As File/Multiple Elements\n");
            var xml3 = new XElement("XMLRoot",
                        new XElement("XMLData", 100),
                        new XElement("XMLData", 200),
                        new XElement("XMLData", 300),
                        new XElement("XMLData", 400));
            Console.WriteLine(xml3);

            //write to an XML document
            var document3 = new XDocument(xml3);
            document3.Save("document3.xml");
            Console.WriteLine(File.ReadAllText("document3.xml"));

            //Element is <tag>
            //Attribute is value inside the tag.
            //<Tag item=500>

            Console.WriteLine("\nAdd Attributes\n");
            var xml4 = new XElement("XMLRoot",
                        new XElement("XMLData", new XAttribute("height", 300), 100),
                        new XElement("XMLData", new XAttribute("height", 250), 200),
                        new XElement("XMLData", new XAttribute("height", 100), 300),
                        new XElement("XMLData", new XAttribute("height", 350), 400));
            Console.WriteLine(xml4);

            //Think of your data in Database table
            //XMLRoot is the name of the table
            //XAttribute is the name of a field with the value
            //XMLData is individual entry in the database

            //XML Revision
            //Create 'Products' root XML
            //Have 2 product items
            //Populate with ProductID, ProductName, CategoryID and UnitPrice

            var xml5 = new XElement("Products",
                       new XElement("Product", new XAttribute("ProductID", 16), new XAttribute("ProductName", "Pavlova"), new XAttribute("CategoryID", 3), new XAttribute("UnitPrice", 17.4500)),
                       new XElement("Product", new XAttribute("ProductID", 3), new XAttribute("ProductName", "Aniseed Syrup"), new XAttribute("CategoryID", 2), new XAttribute("UnitPrice", 10.0000)));

            var xml6 = new XElement("Products",
                      new XElement("Product",
                      new XElement("ProductID", 5),
                      new XElement("ProductName", "Cheese"),
                      new XElement("CategoryID", 3),
                      new XElement("UnitPrice", 10.56)
                      ),
                      new XElement("Product",
                      new XElement("ProductID", 3),
                      new XElement("ProductName", "Cough Syrup"),
                      new XElement("CategoryID", 2),
                      new XElement("UnitPrice", 11.90)
                      )
                      );
            Console.WriteLine(xml6);


            //XML Descendents
            
            var xmlProducts = xml6.Descendants("Product").Select(node => new
            {ProductID = node.Element("ProductID").Value,
             ProductName = node.Element("ProductName").Value,
             CategoryID = node.Element("CategoryID").Value,
             UnitPrice = node.Element("UnitPrice").Value}).ToArray();



            foreach (var product in xmlProducts)
            { Console.WriteLine($"ProductID = {product.ProductID, -2}," +
                                $"ProductName = {product.ProductName,-2}," +
                                $" CategoryID = {product.CategoryID, -2}," +
                                $" UnitPrice = {product.UnitPrice}");
            }


            //Option 2
            var xmldescendents = new XElement("XMLRoot",
                                 new XElement("XMLData", new XAttribute("length", 150), 200),
                                 new XElement("XMLData", new XAttribute("length", 250), 350),
                                 new XElement("XMLData", new XAttribute("length", 300), 500));

            var descendents = new XDocument(xmldescendents);
            descendents.Save("XMLDescendents.xml");
            XDocument doc = XDocument.Load("XMLDescendents.xml");
            foreach (var item in doc.Descendants("XMLRoot"))
            {
                foreach(var element in item.Descendants("XMLData"))
                {
                    Console.WriteLine($"XMLData: value is {element.Value}");
                    Console.WriteLine($"XMLData: Length attribute is {element.Attribute("length").Value}\n");
                }
            }
           

        }
    }
}
