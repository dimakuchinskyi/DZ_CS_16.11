using System.Text;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть текст:");
            string input = Console.ReadLine();

            input += " ";

            string result = "";

            bool isStartOfSentence = true;

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (isStartOfSentence && char.IsLetter(currentChar))
                {
                    result += char.ToUpper(currentChar);
                    isStartOfSentence = false;
                }
                else
                {
                    result += currentChar;
                }
                if (currentChar == '.')
                {
                    isStartOfSentence = true;
                }
            }

            Console.WriteLine("Результат:");
            Console.WriteLine(result.Trim());
        }
    }
}
