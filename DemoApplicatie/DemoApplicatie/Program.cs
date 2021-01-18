using System;

namespace DemoApplicatie
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1;
            double number2;

            Console.WriteLine("Getal 1");
            bool x = Double.TryParse(Console.ReadLine(), out number1);

            Console.WriteLine("Getal 2");
            bool y = Double.TryParse(Console.ReadLine(), out number2);

            if (x && y)
                Console.WriteLine("Uitkomst is: {0}", number1 + number2);
            else
                Console.WriteLine("Invoer is ongeldig.");
        }
    }
}
