using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE31_PRINTING_ERROR_MESSAGES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num);
            }
            catch(OverflowException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            catch(FormatException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                //Console.WriteLine("Something has went Wrong!");
            }
            Console.WriteLine("Good Bye!");
        }
    }
}
