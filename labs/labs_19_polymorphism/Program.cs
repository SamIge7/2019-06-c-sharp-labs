using System;

namespace labs_19_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Parent();
            p.ThrowAParty();
            var c01 = new Child01();
            c01.ThrowAParty();
            var c02 = new Child02();
            c02.ThrowAParty();
        }
    }

   
}
