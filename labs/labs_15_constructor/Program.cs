using System;

namespace labs_15_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
           // var Sam = new Person();
            var Peter = new Person("ABC123", "donttellthis", "Peter");
            Peter.SetNINO("DEF456", "ihavenoidea");
            Console.WriteLine(Peter.SetNINO("DEF456", "donttellthis"));
            Console.WriteLine(Peter.GetNINO("donttellthis"));

        }
    }

    class Person
    {
        private string NINO;
        private string password;
        public string Name;

        // constructor: public + name of class eg public Person
        public Person(string NINO, string password, string Name)
        {
            // this refers to the INSTANCE of the object.
            this.NINO = NINO;
            this.password = password;
            this.Name = Name;
        }

        public bool SetNINO(string newNINO, string password)
        {
            bool itWorked = false;
            if (this.password == password)
            {
                this.NINO = newNINO;
                itWorked = true;
            }
            return itWorked;
        }

        public string GetNINO(string password)
        {
            string returnNINO = "";
            
            if (this.password == password)
            {
                return returnNINO = this.NINO;
            }
            return returnNINO;
        }
    }   
}
