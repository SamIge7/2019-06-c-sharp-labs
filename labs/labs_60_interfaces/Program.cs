using System;

namespace labs_60_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Child();
            c.Name = "Ovie";
            c.Property01 = 100;
            c.UseTool01();
            Console.WriteLine(c.DoThat());
        }
    }

    interface IToolShedItem01 {
        //no fields
        //public int Field01;
        //yes properties
        int Property01 { get; set; } // Public present but not stated
        //yes methods
        void UseTool01(); //abstract (also public)
    }

    interface IToolShedItem02 {
        int ToolName { get; set; }

        string DoThat();
    }

    abstract class Parent {
        public string Name { get; set; }
        public abstract void DoThis();
    }

    class Child : Parent, IToolShedItem01, IToolShedItem02 {
        public int Property01 { get; set; }
        public override void DoThis() { } // mandatory abstract override
        public void UseTool01() { Console.WriteLine("Using Tool01"); }
        public int ToolName { get; set; }

        public string DoThat() => "Shovel"; 
    }
}
