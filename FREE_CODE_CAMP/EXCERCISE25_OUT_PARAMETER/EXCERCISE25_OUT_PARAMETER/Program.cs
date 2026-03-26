using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE25_OUT_PARAMETER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Out Parameter";

            int num = 0;
            test(out num);
            Console.WriteLine(num);

            List<string> shoppingList = new List<string>
            {
                "coffee","milk"
            };

            Console.WriteLine(shoppingList.IndexOf("milk"));
            //Console.WriteLine(findInList("coffee", shoppingList, out int index));
            //Console.WriteLine(" "+ index);

            if(findInList("milk", shoppingList, out int index))
            {
                Console.WriteLine($"Coffe found at index {index}");
            }
            else
            {
                Console.WriteLine("Not found");
            }

            /*int index = -1;

            for (int i = 0; i < shoppingList.Count; i++)
            {
                if (shoppingList[i].ToLower().Equals("milk"))
                {
                    index = i;
                }
            }
            bool found = index > -1;
            Console.WriteLine(found ? "Found" : "Not found");
            */
        }

        static bool findInList(string s, List<string> list, out int index)
        {
            index = -1;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToLower().Equals(s.ToLower()))
                {
                    index = i;
                }
            }
            return index > -1;
        }

        static bool tryparse( string s, out int result)
        {
            result = 0;
            return true;
        }

        static void test(out int num)
        {
            //num = 5;
            //Console.WriteLine($"num = {num}");
            num = 5;
        }
    }
}
