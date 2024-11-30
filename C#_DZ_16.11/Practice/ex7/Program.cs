using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter sentence:");
        string input = Console.ReadLine();
        string[] words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            char[] wordArray = words[i].ToCharArray();
            Array.Reverse(wordArray);
            words[i] = new string(wordArray);
        }
        Console.WriteLine("The result after the coup: " + string.Join(" ", words));
    }
}
