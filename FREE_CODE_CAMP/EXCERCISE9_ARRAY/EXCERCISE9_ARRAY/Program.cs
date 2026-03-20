using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE9_ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            //Console.WriteLine("Enter number: ");
            //numbers[0] = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter number: "); 
            //numbers[1] = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter number: "); 
            //numbers[2] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter number: "); 
            //numbers[3] = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Entered number is {numbers[0]} {numbers[1]} {numbers[2]} {numbers[3]}");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i+1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach(int num in numbers)
            {
                Console.Write($"{num} ");
            }

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}
            
            Console.ReadLine();
        }
    }
}