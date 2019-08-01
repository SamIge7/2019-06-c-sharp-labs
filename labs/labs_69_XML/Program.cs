using System;
using System.Xml.Linq;
using System.IO;

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
                        new XElement("XMLData",new XAttribute("height", 300), 100),
                        new XElement("XMLData", new XAttribute("height", 250), 200),
                        new XElement("XMLData", new XAttribute("height", 100), 300),
                        new XElement("XMLData", new XAttribute("height", 350), 400));
            Console.WriteLine(xml4);

            //Think of your data in Database table
            //XMLRoot is the name of the table
            //XAttribute is the name of a field with the value
            //XMLData is individual entry in the database

        }
    }
}
