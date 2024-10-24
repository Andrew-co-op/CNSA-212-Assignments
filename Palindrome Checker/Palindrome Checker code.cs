using System;

namespace PalindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings Professor Falken do you want to play a game? Let's find palindromes");
            Console.WriteLine("Enter a potential palindrome and press enter");

            string input;

            while ((input = Console.ReadLine()) != null)
            {
                // Remove all whitespace
                string sanitizedInput = RemoveWhitespace(input);

                // Reverse the string
                string reversedInput = ReverseString(sanitizedInput);

                // Check if reversed string matches the original string sans whitespace
                if (sanitizedInput.Equals(reversedInput, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Palindrome unlocked");
                }
                else
                {
                    Console.WriteLine("Whomp, whomp.");
                }
            }
        }

        // Function to remove all whitespace from the string
        static string RemoveWhitespace(string input)
        {
            return string.Join("", input.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
        }

        // Function to reverse a string
        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
