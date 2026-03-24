using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE16_DICTIONARY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Dictionary<int, string> name = new Dictionary<int, string>();
            name.Add(1, "Aba");
            name.Add(2, "Test");
            name.Add(3, "Test1");

            //        or

            Dictionary<int, string> names = new Dictionary<int, string>
            {
                // KeyValuePair
                {1, "Aba"},
                {2, "Test"},
                {3, "Test1"}
            };

            for (int i = 0; i < names.Count; i++)
            {
                KeyValuePair<int, string> pair= names.ElementAt(i);
                Console.WriteLine($"{pair.Key} - {pair.Value}"); 
            }

            Console.WriteLine();

            foreach(KeyValuePair<int, string> items in names)
            {
                Console.WriteLine($"{items.Key} - {items.Value}");
            }*/

            Dictionary<string, string> names = new Dictionary<string, string>()
            {
                {"Maths", "Aba" },
                {"Science", "Test" }
            };

            //Console.WriteLine(names["Maths"]);

            if(names.TryGetValue("Maths", out string name))
            {
                Console.WriteLine(name);
                names["Maths"] = "Joe";
            }   
            else
            {
                Console.WriteLine("Math is not found");
            }

            
            //for(int i = 0; i < names.Count; i++)
            //{
            //    KeyValuePair<string, string> pair = names.ElementAt(i);
            //    Console.WriteLine($"{pair.Key} - {pair.Value}");
            //}

            //Console.WriteLine();

            foreach (var item in names) 
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.WriteLine();
            names.Remove("Maths");

            foreach (var item in names)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.ReadLine();
        }
    }
}