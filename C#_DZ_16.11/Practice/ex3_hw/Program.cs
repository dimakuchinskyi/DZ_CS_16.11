using System.Text;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть рядок для шифрування:");
            string input = Console.ReadLine();

            Console.WriteLine("Введіть зсув для шифру Цезаря:");
            int shift = int.Parse(Console.ReadLine());

            string encrypted = CaesarCipher(input, shift);
            Console.WriteLine($"Зашифрований текст: {encrypted}");

            string decrypted = CaesarCipher(encrypted, -shift);
            Console.WriteLine($"Розшифрований текст: {decrypted}");
        }

        static string CaesarCipher(string text, int shift)
        {
            char[] result = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];

                if (char.IsUpper(currentChar))
                {
                    result[i] = (char)((((currentChar - 'A') + shift) % 26 + 26) % 26 + 'A');
                }
                else if (char.IsLower(currentChar))
                {
                    result[i] = (char)((((currentChar - 'a') + shift) % 26 + 26) % 26 + 'a');
                }
                else
                {
                    result[i] = currentChar;
                }
            }

            return new string(result);
        }
    }
}
