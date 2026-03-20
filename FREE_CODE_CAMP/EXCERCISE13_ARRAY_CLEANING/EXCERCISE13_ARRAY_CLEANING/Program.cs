using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE13_ARRAY_CLEANING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                0,1,2,3,4,5
            };

            // syntax:
            // Array.Clear( array_name, idx number, length);
            Array.Clear(numbers, 4, 2);
            
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = default;
            //}

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.ReadLine();
        }
    }
}
