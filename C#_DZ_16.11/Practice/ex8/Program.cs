using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter sentence:");
        string input = Console.ReadLine();
        string vowels = "aeiouAEIOU";
        int vowelCount = 0;
        foreach (char c in input)
        {
            if (vowels.Contains(c))
            {
                vowelCount++;
            }
        }
        Console.WriteLine($"Count of vowels in sentence: {vowelCount}");
    }
}
