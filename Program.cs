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

            double testf1 = MaxNumber.ReturnMaxFloat(9.1, 3.4, 4.9);
            double testf2= MaxNumber.ReturnMaxFloat(3.4, 9.1, 4.9);
            double testf3= MaxNumber.ReturnMaxFloat(9.0, 5.0, 9.1);
            Console.WriteLine($"Max float value is {testf1}");
            Console.WriteLine($"Max float value is {testf2}");
            Console.WriteLine($"Max float value is {testf3}");

          

            Console.ReadKey();


        }
    }
}
