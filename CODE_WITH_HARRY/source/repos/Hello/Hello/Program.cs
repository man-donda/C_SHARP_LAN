using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hello
{
    internal class Program
    {
        // Methods in C#:
        static void greet(string name)
        {
            Console.WriteLine("Hey, Good Morning! "+name);
        }

        static float avg(int a, int b, int c)
        {
            float sum = a + b + c;
            return sum/3;
        }

        static void Main(string[] args)
        {
            // int man = 21;
            // string inp = Console.ReadLine();
            // Console.Write("Enter your name: ");
            // Console.WriteLine("Your name is: "+inp);
            // Console.WriteLine("Hello World");
            // Console.WriteLine("Hello Man ");
            // Console.WriteLine("I Love C# and the number is " + man);

            // int a = 35;
            // float b = 35.7F;
            // double c = 34.5D;
            // char d = 'm';
            // string e = "This is a String";
            // bool isGreat = true;
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // Console.WriteLine(c);
            // Console.WriteLine("The given character is "+d);
            // Console.WriteLine(e);
            // Console.WriteLine(isGreat);

            //  Type Casting:
            // There are two types of Type Casting.
            // 1. Implicit Casting:
            //     - char to int to long to float to double.
            // 2. Explicit Casting:
            //     - int x = (int)3.5;
            // double x1 = (double)3.5;
            // Console.WriteLine(x1); 

            // int x = 3;
            // double y = x;
            // int z = 'y';
            // float varr = Convert.ToInt32(5.14);
            // Console.WriteLine(varr);
            // Console.WriteLine(x);
            // Console.WriteLine(y);
            // Console.WriteLine(z); // it returns ascii value of value of z.


            // Console.Write("Enter your name: ");
            // string name = Console.ReadLine();
            // Console.WriteLine("Hey Hello "+name);

            // Console.Write("How many candies do you want?: ");
            // string candy = Console.ReadLine();
            // Console.WriteLine("You will get 4 more candies "+ (Convert.ToInt32(candy) +4));


            // Operators in C#:
            // 1. Arithmetic Operator
            // 2. Assignment Operator
            // 3. Logical Operator
            // 4. Comparison Operator


            // Example of Arithmetic Operator:
            // int a = 20;
            // int b = 10;
            // Console.WriteLine("The value of a+b is "+ (a + b));
            // Console.WriteLine("The value of a-b is "+ (a - b));
            // Console.WriteLine("The value of a*b is "+ (a * b));
            // Console.WriteLine("The value of a/b is "+ (a / b));

            // Example of Assignment Operator:
            // int a = 4;
            // int b = a;
            // b += 4;
            // b -= 4;
            // b *= 4;
            // b /= 4;
            // Console.WriteLine(b);

            // Example of Logical Operator:
            // Console.WriteLine(true && false);
            // Console.WriteLine(true && true);
            // Console.WriteLine(false && false);
            // Console.WriteLine(true || false);
            // Console.WriteLine(true || true);
            // Console.WriteLine(false || false);
            // Console.WriteLine(!true);
            // Console.WriteLine(!false);

            // Example of Comparison Operator:
            // Console.WriteLine(324 > 555);
            // Console.WriteLine(324 <= 555);
            // Console.WriteLine(324 >= 555);
            // Console.WriteLine(324 != 555);
            // Console.WriteLine(324 == 555);
            // Console.WriteLine(5 == 5);


            // Math Class in C#:
            // int a = Math.Max(34, 345);
            // Console.WriteLine(a);
            // int b = Math.Min(34, 345);
            // Console.WriteLine(b);
            // double c = Math.Sqrt(36);
            // Console.WriteLine(c);
            // int d = Math.Abs(-34);
            // Console.WriteLine(d);

            // String's Methods:
            // string hello = "Hello world, This is Man";
            // Console.WriteLine(hello);
            // Console.WriteLine("The length of the string is "+hello.Length);
            // Console.WriteLine(hello.ToUpper());
            // Console.WriteLine(hello.ToLower());
            // Console.WriteLine(hello+", You are nice");
            // Console.WriteLine(string.Concat(hello,", You are nice."));

            // String Interpolation:
            // Console.Write("Enter your name: ");
            // string name = Console.ReadLine();
            // Console.Write("Enter Candies: ");
            // string candies = Console.ReadLine();
            // Console.WriteLine($"Your name is {name} and You will get {candies} candies.");

            // string hello = "Hello world, This is Man";
            // Console.WriteLine(hello[0]);
            // Console.WriteLine(hello.IndexOf("is"));
            // Console.WriteLine(hello.Substring(6));
            // Console.WriteLine(hello);
            // string hello1 = "Hello world, This \" is Man"; // We can add double quote(") in string via using back-slash.
            // Console.WriteLine(hello1);

            // Else - If Condition:
            // Console.Write("Enter your age: ");
            // string agestr = Console.ReadLine();
            // int age = Convert.ToInt32(agestr);
            // if (age < 2)
            // {
            //     Console.WriteLine("You are just born.");
            // }
            // else if(age > 18)
            // {
            //     Console.WriteLine("You can drive.");
            // }
            // else
            // {
            //     Console.WriteLine("You can not drive.");
            // }

            // Switch Case Statement:
            // Console.WriteLine("Enter your age");
            // string agestr = Console.ReadLine();
            // int age = Convert.ToInt32(agestr);

            // switch (age)
            // {
            //     case 18:
            //         Console.WriteLine("wait for an year");
            //         break;

            //     case 20:
            //         Console.WriteLine("You are 20");
            //         break;

            //     default:
            //         Console.WriteLine("You can enjoy");
            //         break;
            // }

            // Loops in C#:

            // While loop:
            // int i = 1;
            // while(i <= 5)
            // {
            //     Console.WriteLine(i);
            //     i++;
            // }

            // Do - While loop:
            // int i = 1;
            // do
            // {
            //     Console.WriteLine(i);
            //     i++;
            // } while (i <= 5);

            // For loop:
            // for (int i = 1; i <= 5; i++) { 

            //    Console.WriteLine(i);
            // }

            // Functions in C#:
            // greet("man");
               
            // float tamp = avg(2, 4, 6);
            // Console.WriteLine(tamp); 

            // OOPs - Classes and Objects:
            //Player tommy = new Player();
            //Console.WriteLine(tommy.getHealth());
            //tommy.setHealth(57);
            //Console.WriteLine(tommy.getHealth());
                
            Console.ReadLine();
        }
    }
} 