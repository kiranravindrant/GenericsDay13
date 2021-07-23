using System;


namespace FindMax
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding max Number :");

            int[] intArray = { 52, 81, 72, 50 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();
            double[] doubleArray = { 3.14, 28.5, 14.4, 79.02, 936.85 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();
            string[] stringArray = { "Apple", "Bannana", "Peach", };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();

        }
    }
}
    

