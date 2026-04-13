using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_PROJECT01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 1000; // Initial balance
            int choice;

            do
            {
                Console.WriteLine("\n===== ATM MENU =====");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Your Balance: " + balance);
                        break;

                    case 2:
                        Console.Write("Enter amount to deposit: ");
                        double deposit = Convert.ToDouble(Console.ReadLine());

                        if (deposit > 0)
                        {
                            balance += deposit;
                            Console.WriteLine("Deposit Successful!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount!");
                        }
                        break;

                    case 3:
                        Console.Write("Enter amount to withdraw: ");
                        double withdraw = Convert.ToDouble(Console.ReadLine());

                        if (withdraw > 0 && withdraw <= balance)
                        {
                            balance -= withdraw;
                            Console.WriteLine("Withdrawal Successful!");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient balance or invalid amount!");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Thank you for using ATM!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }

            } while (choice != 4);
        }
    }
}
