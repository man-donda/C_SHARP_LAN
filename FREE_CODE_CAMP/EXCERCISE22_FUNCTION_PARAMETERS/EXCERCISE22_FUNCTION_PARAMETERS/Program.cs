using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EXCERCISE22_FUNCTION_PARAMETERS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = $"Aba - 23";

            Console.WriteLine(add(50, 50));

            int num1 = readInt("Enter number 1");
            int num2 = readInt("Enter number 2");

            int result = add(num1, num2);
            Console.WriteLine($"The sum is {result}");

            string name = readString("Enter your name");
            int age = readInt("Enter your age");

            string details = userDetails(name, age);
            Console.WriteLine(details);
        }

        static string userDetails(string name, int age)
        {
           return $"Hello my name is {name} and age is {age}!";
        }

        static string readString(string message)
        {
            Console.Write($"{message}: ");
            return Console.ReadLine();
        }
        static int readInt(string message)
        {
            Console.Write($"{message}: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int add(int a, int b)
        {
            return a+b;
        }
    }
}
