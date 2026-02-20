using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Console.Write("Enter number1: ");
            // int num1 = Convert.ToInt32(Console.ReadLine());

            // Console.Write("Enter number2: ");
            // int num2 = Convert.ToInt32(Console.ReadLine());

            // int answer = num1 * num2;
            // int actualAnswer = 0;

            // Console.WriteLine("What is " + num1 + " X " + num2 + " = ");
            // Console.WriteLine();

            // while (answer != actualAnswer) {
            //     string answerInput = Console.ReadLine();
            //     actualAnswer = Convert.ToInt32(answerInput);

            //     if (answer != actualAnswer)
            //     {
            //         Console.WriteLine("Close but not right");
            //     }
            // }
            // Console.WriteLine("Well done");

            // Loops in C# :
            // for loop:

            // Console.Write("What you want to repeat/print ?: ");
            // string word = Console.ReadLine();
            // Console.Write("how many time do you want to print: ");
            // int count = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine();

            // for(int i = 0; i < count; i++)
            // {
            //     Console.WriteLine(word);
            // }

            // int i = 0;
            // while(i < 5)
            // {
            //     Console.WriteLine("Hi");
            //     i++;
            // }

            // int i = 0;
            // do
            // {
            //     Console.WriteLine("Hi");
            //     i++;
            // }while (i < 5);

            // Conditional Operation:
            int age = 10;
            if (age >= 0)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            // Ternery Operation:
            string result = age >= 0 ? "Valid" : "Invalid";
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
