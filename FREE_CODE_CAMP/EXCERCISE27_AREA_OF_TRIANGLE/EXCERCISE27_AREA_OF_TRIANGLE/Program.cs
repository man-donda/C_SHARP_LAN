using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE27_AREA_OF_TRIANGLE
{

    /*
     - Ask user for width and height, store them
     - Create function to calculate the area
     - Function should calculate the area using: (width * height) / 2
     - Call in main and print out the area of the triangle
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "The area of Rectangle";

            int width = readInt("Enter width");
            int height = readInt("Enter height");

            Console.WriteLine("The area is "+calculateArea(width, height));
        }

        static int readInt(string message)
        {
            Console.Write($"{message}: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int calculateArea(int width, int height)
        {             
            return (width * height) / 2;
        }
    }
}
