using System.Text;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть текст:");
            string inputText = Console.ReadLine();

            Console.WriteLine("Введіть неприпустиме слово:");
            string forbiddenWord = Console.ReadLine();

            int replacements = 0;

            string resultText = inputText;
            while (resultText.Contains(forbiddenWord))
            {
                resultText = resultText.Replace(forbiddenWord, new string('*', forbiddenWord.Length));
                replacements++;
            }

            Console.WriteLine("\nРезультат:");
            Console.WriteLine(resultText);

            Console.WriteLine($"\nСтатистика: {replacements} заміни слова {forbiddenWord}.");
        }
    }
}
