using System;

namespace SnapLab_18_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog(100);
            Dog dog2 = new Dog(50);
            Dog dog3 = new Dog(75);

            Dog max;
            Dog min;
            Dog middle;

            if (dog1.CompareTo(dog2) == 1)
            {
                if(dog1.CompareTo(dog3) == 1)
                {
                    if (dog2.CompareTo(dog3) == 1)
                    {
                        middle = dog3;
                    }
                    else
                    {
                        middle = dog2;
                    }

                    max = dog1;

                }
                else
                {
                    min = dog3;
                }

                max = dog1;
            }
            else
            {
                min = dog2;
            }
           
        }
    }
    class Dog: IComparable
    {
        public int Height { get; set; }
        public int CompareTo(Object o)
        {
            Dog d = (Dog)o;
            if (this.Height < d.Height) 
            {
                return -1;
            }
            else if (this.Height == d.Height)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }

        public Dog(int height)
        {
            this.Height = height;
        }
    }
}
