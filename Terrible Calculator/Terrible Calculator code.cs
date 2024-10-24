using System;
using System.Collections.Generic;

namespace TerribleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's calculate badly I hope you like adding because that's all we support");
            Console.WriteLine("Enter the values to calculate on one line at a time");
            Console.WriteLine("When you are done, enter the text \"end\" or press CTRL+Z on Windows or CTRL+D on Linux");

            List<double> values = new List<double>();
            string input;

            while (true)
            {
                input = Console.ReadLine();

                if (input == null || input.Trim().ToLower() == "end")
                {
                    break;
                }

                try
                {
                    double number = double.Parse(input);
                    values.Add(number);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input, try again.");
                }
            }

            double result = 0;

            foreach (var value in values)
            {
                result += value;
            }

            Console.WriteLine($"The answer is: {result}");
        }
    }
}

