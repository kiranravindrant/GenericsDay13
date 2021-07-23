using System;


namespace FindMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Number");
            int test1=MaxNumber.ReturnMaxInteger(9, 7, 5);
            int test2= MaxNumber.ReturnMaxInteger(7, 9, 5);
            int test3= MaxNumber.ReturnMaxInteger(7, 5, 9);
            Console.WriteLine($"Max value is {test1}");
            Console.WriteLine($"Max value is {test2}");
            Console.WriteLine($"Max value is {test3}");




            Console.ReadKey();


        }
    }
}
