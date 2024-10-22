using System;

namespace Echo
{
    class Program
    {
        static void Main(string[] args)
        {
            // If no arguments are provided, do nothing.
            if (args.Length == 0)
            {
                Console.WriteLine("No input provided.");
                return;
            }

            // Check if the first argument is 'R' for reverse
            if (args[0].ToUpper() == "R")
            {
                // Reverse the arguments excluding the first 'R'
                Array.Reverse(args, 1, args.Length - 1);
            }

            // Print out the arguments either normal or reversed
            Console.WriteLine(string.Join(" ", args.Skip(1)));
        }
    }
}
