using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int actualAnswer = num1 * num2;

            Console.Write("What is " + num1 + " X " + num2 + " = ");
            int answer = Convert.ToInt32(Console.ReadLine());

            if(actualAnswer == answer)
            {
                Console.WriteLine("Well done");
            }else
            {
                Console.WriteLine("close but not right.");
            }

            Console.ReadLine();
        }
    }
}
