using System;

namespace labs_29_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte
            byte b01 = 0;  //min
            byte b02 = 255; //max
            byte b03 = 0b_1010_0101; //binary literal
            byte b04 = 0x_FF;
            byte b05 = 0x_0C;
            Console.WriteLine((int)b04);

            //buffer
            //Youtube: video is split into tiny parts
            //each part is the size of a 'buffer'
            //'video is buffering
            //buffer is array of bytes
            byte[] myBuffer = new byte[4000];  //chunk size for sending a video

            //char
            //ASCII: first computers maps a number to every character
            // h is 104, H is 72
            char char01 = 'c';
            char char02 = 'd';
            Console.WriteLine((int)char01);

            //unicode is upgrade to ascii
            // utf-8 web getbootstrap.com
            // utf-16 unicode - chinese characters

            const int num10 = 10;
            // can't change num10 10 = 100;
            const double DISPLAY_IT_LIKE_THAT = 5.67;
            var num01 = 10;
            var num02 = "hi";

            //alias
            string x = "hi"; //use this
            String y = "there"; //String is the class: don't use

            //readonly: use in preference to const
            //const change value to LITERAL (not goood)
            //readonly preserve as variable (better)

            //NULL-CHECK

            string AuthorName = null;
           
            if (AuthorName != null)
            {
                Console.WriteLine(AuthorName.Length);
                int nameLength = AuthorName.Length;
            }
            int? nameLength2 = AuthorName?.Length;
            //If Name is null - return null otherwise return length

            int? nullableItem = null;
            // int cannotMakeNull = null;
            int defaultNumber = default; //0
            int? defaultNullable = default; //null
            Console.WriteLine(defaultNullable);

            //NULL COALESCE

            //TUPLES
            void DoThis() { }
            int DoThat()
            {
                return -1;
            }

            void DoingSomething (out int result, out string result2)
            {
                result = -1;
                result2 = "hi";
            }
            //TUPLE IS AN ANONYMOUS TYPE
            //DECLARE
            (string x01, int y01, bool z01) DoingSomethingElse()
            {
                return ("hi", 10, false);
            }

            //CALL
            var output01 = DoingSomethingElse();

            //GET INDIVIDUAL ITEMS
            Console.WriteLine($"{output01.x01}{output01.y01}{output01.z01}");
            
        }
    }

    class X
    {
        public readonly string Y;
    }
}
