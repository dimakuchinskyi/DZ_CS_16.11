using System.Text;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть арифметичний вираз (тільки + і -):");
            string input = Console.ReadLine();

            double result = 0;
            double currentNumber = 0;
            char lastOperator = '+';

            input += " ";

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (char.IsDigit(currentChar) || currentChar == '.')
                {
                    string number = "";

                    while (i < input.Length && (char.IsDigit(input[i]) || input[i] == '.'))
                    {
                        number += input[i];
                        i++;
                    }

                    currentNumber = double.Parse(number);
                    i--;
                }
                else if (currentChar == '+' || currentChar == '-')
                {
                    if (lastOperator == '+')
                    {
                        result += currentNumber;
                    }
                    else if (lastOperator == '-')
                    {
                        result -= currentNumber;
                    }

                    lastOperator = currentChar;
                }
            }

            Console.WriteLine($"Результат: {result}");
        }
    }
}
