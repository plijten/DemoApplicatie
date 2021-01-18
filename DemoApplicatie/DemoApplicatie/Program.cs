using System;

namespace DemoApplicatie
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Uitkomst is: {0}", number1 + number2);
        }
    }
}
