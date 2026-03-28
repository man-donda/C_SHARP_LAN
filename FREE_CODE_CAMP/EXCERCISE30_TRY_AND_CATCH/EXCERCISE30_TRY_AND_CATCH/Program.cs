using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE30_TRY_AND_CATCH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // System.FormatException
            // System.OverFlowException

            bool looping = true;

            while (looping)
            {
                try
                {
                    Console.Write("Enter number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Entered number is {num}");
                    
                    looping = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please, enter only numbers!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Please enter only a number less than 2 billion!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Something has went Wrong!");
                }
            }
                        
            Console.WriteLine("Good Bye!");
        }
    }
}