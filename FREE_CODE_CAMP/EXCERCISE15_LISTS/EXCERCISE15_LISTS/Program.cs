using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
              
namespace EXCERCISE15_LISTS
{             
    internal class Program
    {         
        static void Main(string[] args)
        {     
            List<int> listNumbers = new List<int>();
              
            for(int i = 0; i < 3; i++)
            { 
                Console.WriteLine("Enter number: ");
                listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            } 

              
            Console.Write("Lists: ");
            for (int i = 0; i < listNumbers.Count; i++)
            {
                Console.Write($"{listNumbers[i]} ");
            }
            listNumbers.RemoveAt(0);

            foreach (int items in listNumbers)
            {
                Console.Write($"{items} ");
            }
            
        }
    }
}