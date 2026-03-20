using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE10_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int anglesCount = 3;
            int[] angles = new int[anglesCount];

            for (int i = 0; i < anglesCount; i++)
            {
                Console.WriteLine($"Enter angle {i + 1}: ");
                angles[i] = Convert.ToInt32(Console.ReadLine());
            }

            int angleSum = 0;

            foreach (int angle in angles)
            {
                angleSum += angle;
            }

            Console.WriteLine($"The sum of the angles is {angleSum}");

            //if(angleSum == 180)
            //{
            //    Console.WriteLine("Valid");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}

            Console.WriteLine(angleSum == 180 ? "Valid" : "Invalid");
        }
    }
}
