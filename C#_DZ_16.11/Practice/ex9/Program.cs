using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter sentence:");
        string inputString = Console.ReadLine();
        Console.WriteLine("Enter word for search:");
        string searchWord = Console.ReadLine();
        int count = 0;
        int startIndex = 0;
        while ((startIndex = inputString.IndexOf(searchWord, startIndex, StringComparison.OrdinalIgnoreCase)) != -1)
        {
            count++;
            startIndex += searchWord.Length;
        }
        Console.WriteLine($"Number of occurrences of a substring '{searchWord}': {count}");
    }
}
