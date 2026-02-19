using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE1
{
    // EVEN - ODD:
    internal class Program
    {
        static void Main(string[] args)
        {
            // int num1 = 10;
            // int num2 = 2;
               
            // int reminder = num1 % num2;
            // Console.WriteLine(reminder);
               
            // num1 = 11;
            // reminder = num1 % num2;
            // Console.WriteLine(reminder);

            Console.WriteLine("Hello, My name is Man");

            Console.Write("Whats your name: ");
            string name = Console.ReadLine();

            Console.Write("Whats your age: ");
            string agestr = Console.ReadLine();
            int age = Convert.ToInt32(agestr);

            Console.WriteLine();
            Console.WriteLine("Your name is "+name+" and your age is "+age);

            if(age >= 18 && age <= 25)
            {
                Console.WriteLine("You are between 18 and 25");
            }
            else if(age < 18)
            {
                Console.WriteLine("You are under 18");
            }
            else 
            {
                Console.WriteLine("You are 26 or older");
            }

            Console.ReadLine();
        }
    }
}