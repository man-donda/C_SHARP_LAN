using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE8_PASSWORD_CHECKER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            Console.Write("Enter Password again: ");
            string passwordC = Console.ReadLine();

            if (!password.Equals(string.Empty))
            {
                if (!passwordC.Equals(string.Empty))
                {
                    if((password.Length >= 8 && passwordC.Length >= 8) && (password.Length <= 16 && passwordC.Length <= 16))
                    {
                        if (password.Equals(passwordC))
                        {
                            Console.WriteLine("Password Match");
                        }
                        else
                        {
                            Console.WriteLine("Password does not match.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please Enter character between 8 and 16.");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Please enter password confirmation.");
                }                         
            }
            else
            {
                Console.WriteLine("Please Enter Password.");
            }
        }
    }
}