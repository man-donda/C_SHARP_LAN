using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE14_ARRAY_INDEXOF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                90, 199, 22, 50, 30
            };
            Boolean isFound = false; 

            Console.Write("Enter number you want to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            // Syntax:
            //Array.IndexOf(array_name, value); --> search in whole array
            //Array.IndexOf(array_name, value, 2); --> search from 2nd idx postion in array
            //Array.IndexOf(array_name, value, 1 , 3); --> search between 1st and 3rd idx postion in array

            int position = Array.IndexOf(numbers, search);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == search)
                {
                    Console.WriteLine($"Number {search} has been found at position {position + 1}");
                    isFound = true;
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"Number {search} has not been found in this Array");
            }
        }
    }
}