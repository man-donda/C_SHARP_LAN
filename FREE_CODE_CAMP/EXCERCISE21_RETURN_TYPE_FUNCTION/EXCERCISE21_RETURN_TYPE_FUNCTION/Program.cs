using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE21_RETURN_TYPE_FUNCTION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ageNamePair();
            
            printIntro();

            add();

            int[] numbers = new int[3];
            
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = readArray();
            }

            foreach (var num in numbers)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine();

            int[] Newnumbers = createRandomArray();

            foreach(var num in Newnumbers)
            {
                Console.Write($"{num} ");
            }

            Console.ReadLine();
        }   
        
        static int add()
        {
            int a, b;
            Console.WriteLine("Enter num1 and num2: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;
            Console.WriteLine($"The sum of both number is {c}");
            return c;

        }

        static int[] createRandomArray()
        {
            int[] numbers = new int[3]
            {
                0, 1, 2
            };
            return numbers;
        }

        static int readArray()
        {
            Console.Write($"Enter number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static string ReturnName()
        {
            return "Aba";
        }

        static int ReturnAge()
        {
            return 23;
        }

        static string ageNamePair()
        {
            return $"{ReturnName()} - {ReturnAge()}";
        }

        static void printIntro()
        {
            //String name = ReturnName();
            //int age = ReturnAge();
            //string output = $"Hello my name is {name} and my age is {age}";

            //Console.WriteLine(output + Environment.NewLine);

            Console.WriteLine($"Hello my name is {ReturnName()} and my age is {ReturnAge()}");
        }
    }
}
