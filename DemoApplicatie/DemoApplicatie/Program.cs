﻿using System;

namespace DemoApplicatie
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1;
            double number2;

            Console.WriteLine("Getal 1");
            bool value1Correct = Double.TryParse(Console.ReadLine(), out number1);

            Console.WriteLine("Getal 2");
            bool value1Correct = Double.TryParse(Console.ReadLine(), out number1);

            bool value2Correct = Double.TryParse(Console.ReadLine(), out number2);

            if (value1Correct && value2Correct)
                Console.WriteLine("Uitkomst is: {0}", number1 + number2);
            else
                Console.WriteLine("Invoer is ongeldig.");
        }

        private void Multiply(double number1, double number2)
        {
            // Just for demo.
            Console.WriteLine(number1 * number2);
        }
    }
}
