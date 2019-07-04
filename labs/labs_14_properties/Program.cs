using System;

namespace labs_14_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var Sam = new Person();
            Sam.Name = "Sam";
            Sam.SetNINO("ABC123", "");
        }
    }

    class Person
    {
        private string NINO;
        private string password;

        public string Name { get; set; }

        // getter/setter
        public void SetNINO(string newNINO, string password) {
            if(this.password == password)
            {
                this.NINO = newNINO;
            }
        }
    }
}
