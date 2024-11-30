using System;
namespace ex6
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a sentence: ");
            string input = Console.ReadLine();

            string[] word = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Count of word in sentence: " + word.Length );
        }
    }
}
