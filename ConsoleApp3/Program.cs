using System;

namespace ConsoleApp3
{
    class Program
    {
        static int a = 16;
        static double b = 5.1;
        static void Main(string[] args)
        {

            int c = a + b; // This wont be executed, because we cant convert a double into a int. int can only contain whole numbers.

            double d = a + b; // here it can be executed since a double can handle both whole numbers and numbers with a comma in them

            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
