using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE24_NAMED_PARAMETERS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = $"Named Parameters";
            string name = "Aba";
            int age = 23;
            string address = "1 Something road";

            printDetails(name, age, address);

            //     or

            string nameInput = "Aba";
            int ageInput = 23;
            string addressInput = "1 Something road";

            printDetails(nameInput, ageInput, addressInput); // in correct order

            printDetails(age: ageInput,
                         name: nameInput, 
                         address: addressInput);  // in different order
        }

        static void printDetails(string name, int age, string address)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Address: {address}");
        }
    }
}
