using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check if a name was provided as a command-line argument
            string name = args.Length > 0 ? args[0] : "user";

            // Output the greeting
            Console.WriteLine($"Hi from CNSA 212, {name}!");
        }
    }
}
