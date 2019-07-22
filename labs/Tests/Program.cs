using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] r = new int[10] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            var x = Enumerable.Range(1, 10).ToArray();
            int[] y = new int[4] { 10, 20, 30, 40 };
            Eng35Tests.CreateArrayFromSentence("Sam is Amazing");
            Eng35Tests.CreateArrayFromSentence2("Sam is the best");
            Eng35Tests.Calculate_Words_In_Sentence("Sam is Amazing");
            Eng35Tests.Turn_First_Word_To_Uppercase("Sam is Amazing");
            Eng35Tests.Mega_Multiple_Coding_Loop(r);
            Eng35Tests.SumOfArray(x);
            Eng35Tests.How_Many_Numbers_Divisible_By(2, 10, 4);
            Eng35Tests.Array_Loop_Queue_Stack(y);


            /*Write a short program that prints each number from 1 to 100 on a new line. 

            For each multiple of 3, print "Fizz" instead of the number.

            For each multiple of 5, print "Buzz" instead of the number. 


            For numbers which are multiples of both 3 and 5, print "FizzBuzz" instead of the number*/

            for (int i = 1; i <= 100; i++) 
            {
                if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                else if (i % 5 == 0) 
                    {
                        Console.WriteLine("Buzz");
                    }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    public class Eng35Tests
    {
        // Pass in a sentence and return an array of individual words
        public static string[] CreateArrayFromSentence(string sentence)
        {
            string[] words = sentence.Split(' ');
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            return words;
        }

        public static string[] CreateArrayFromSentence2(string sentence)
        {
            string[] words = sentence.Split(' ');
            foreach (var word in words)
            {
                Console.WriteLine(words);
            }
            return words;
        }

        // Pass in a sentence and calculate number of words in sentence
        public static int Calculate_Words_In_Sentence(string sentence)
        {
            int counter = 0;
            string[] words = sentence.Split(' ');
            foreach (var word in words)
            {
                counter++;
            }
            Console.Write(counter);
            return counter;

            /*
            string text = "Sam Is Amazing";
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    if ((i + 1) == text.Length)
                    {
                        count++;
                    }
                    else
                    {
                        if (text[i + 1] == ' ')
                        {
                            count++;
                        }
                    }
                }
            }
            return count;*/
        }

        public static int CalculateWordsInSentence2(string sentence)
        {
            int counter = 0;
            string[] words = sentence.Split(' ');
            foreach (var word in words)
            {
                counter++;
            }
            Console.WriteLine(counter);
            return counter;
        }

        public static string Turn_First_Word_To_Uppercase(string sentence)
        {
            //"this is a sentence" returns "THIS is a sentence"
            string[] words = sentence.Split(' ');
            words[0] = words[0].ToUpper();
            string UpperFirstWord = string.Join(" ", words);
            Console.WriteLine(UpperFirstWord);
            return UpperFirstWord;


        }

        public static string Turn_All_Words_To_Uppercase_But_Last_Word_To_Lowercase(string sentence)
        {
            //"this is a sentence" returns "THIS IS A sentence"
            return "";
        }
        public static int Mega_Multiple_Coding_Loop(int[] myArray)
        {
            /*Coding Task

            

            
            

            Create a Cat class with string Name and int Age.
            Have a Constructor.

            Create a list of Cats and foreach loop => create new cat with name 'Cat'+number' and Age=number
                            eg first cat is called 'Cat28' and has Age 28.

            Print the list of cats with names and ages

            Return the total of all the ages of all cats!*/

            List<Cat> cats = new List<Cat>();
            // Pass in array of 10 numbers[10, 11, 15, 25..
            //While loop ==> add one to each number[11, 12, 16...
            Console.WriteLine("\n Now Adding 1 \n");
            int counter = 0;
            while (counter < myArray.Length)
            {
                myArray[counter]++;
                Console.Write(myArray[counter] + " ");
                counter++;
            }

            //Do..While loop ==> add 3 to each number[14, 15, 19..
            Console.WriteLine("\n Now Adding 3 \n");

            int c = 0;
            do
            {
                myArray[c] += 3;
                Console.Write(myArray[c] + " ");
                c++;
            } while (c < myArray.Length);


            //Foreach loop ==> double each number[28, 30, 38...
            Console.WriteLine("\n Now Doubling Up\n");

            //int x = 0;
            foreach (int i in myArray)
            {
                Console.Write(i * 2 + " ");
                var ca = new Cat("Cat" + i.ToString(), i);
                cats.Add(ca);
                //myArray[x] *= 2;
                //x++;


            }
            Console.WriteLine("\n Cat Counter\n");

            int totalAge = 0;
            foreach (var cat in cats)
            {
                totalAge += cat.Age;
                Console.WriteLine($"Name{cat.Name,-20}{cat.Age,-10}");
            }
            return totalAge;
        }

        public static int How_Many_Numbers_Divisible_By(int start, int end, int divisor)
        {
            //how many integers are divisible by given divisor in the given range
            //example (2,10,4) means start at 2 anc count up to 10
            //only 4 and 8 are divisible by 4
            //so answer is 2
            int c = 0;
            for (int i = start; i <= end; i++)
            {
                
                if (i % divisor == 0)
                {
                    c++;
                    Console.WriteLine(c);
                }
            }
            return c;
        }


        public static int SumOfArray(int[] myArray4)
        {
            int sum = 0;
            foreach (int num in myArray4)
            {
                sum += num;
            }
            return sum;
        }

        public static double Exponential(int x, int y, int n)
        {
            double exp = Math.Pow((x * y), n);
            return exp;
        }

        public static int[] SortArray(int[] myArray5)
        {
            Array.Sort(myArray5);
            return myArray5;
        }

        public static int Array_Loop_Queue_Stack(int[] NumArray)
        {
            List<int> list03 = new List<int>();

            //create a list, multiply by 10
           
            foreach (var item in NumArray)
            {
                list03.Add(item * 10);
            }
            //create a queue, add 1
            var queue02 = new Queue<int>();

            foreach (var item in list03)
            {
                queue02.Enqueue(item + 1);
            }
            //create a stack, add 2
            var stack02 = new Stack<int>();
            int sum = 0;
            foreach (var item in queue02)
            {
                stack02.Push(item + 2);
            }
            //what's the sum?
            foreach (var item in stack02)
            {
                sum += item;
            }
            return sum;
        }
        


    }




    public class Cat 
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Cat(string Name, int Age)
        {
            this.Age = Age;
            this.Name = Name;
        }

            
    }

}
