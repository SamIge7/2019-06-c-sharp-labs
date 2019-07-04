using System;

namespace labs_22_first_test
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class LabWork
    {
        public int CubeNumbers (int x, int y, int z)
        {
            return (x*y*z);
        }

        static public int CubeNumbersStatic(int x, int y, int z)
        {
            return (x * y * z);
        }

        public static int GetLengthOfArray(int[] myArray)
        {
            return myArray.Length;
        }

        public static int SumTotalofArrayMembers( int[] array)
        {
            int sum = 0;
            foreach(int i in array)
            {
                sum += 1;
            }
            return sum;
        }
    }
}
