using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXCERCISE7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string.Empty :
            // Console.Write("Enter your name: ");
            // string name = Console.ReadLine();
               
            // if(name != string.Empty)
            // {
            //     Console.WriteLine($"Your name is {name}");
            // }
            // else
            // {
            //     Console.WriteLine("Name is empty.");
            // }
               
            //  Compare:
            // string message1 = "Hello";
            // string message2 = "Hello";
               
            // if (message1.Equals(message2))
            // {
            //     Console.WriteLine("Same");
            // }
            // else {
            //     Console.WriteLine("Different");
            // }

            // Iteration Looping:
            //string message = "My name is Man";

            //for(int i = 0; i < message.Length; i++)
            //{
            //    Console.Write(message[i]);
            //    Thread.Sleep(100 ); //Type one by one character automatically
            //}

            //Console.WriteLine();
            
            //// Contains character:
            //Console.WriteLine(message.Contains('M'));

            // Reverse the String:
            Console.Write("Enter the Message: ");
            string message = Console.ReadLine();

            Console.WriteLine(message[0]);
            Console.WriteLine(message.Length);

            for (int i = 0; i < message.Length; i++) {
                Console.Write(message[i]);
            }
            Console.WriteLine();

            for (int i = message.Length - 1; i >= 0; i--)
            {
                Console.Write(message[i]);
            }

                Console.ReadLine();
        }
    }
}
