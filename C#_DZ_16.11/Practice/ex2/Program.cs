using System;
namespace ex2
{
    internal class Program
    {
        static void Main(string[] arrgs)
        {
            int[] mas = { 1, 2, 3, 435, 5, 432, 7, 8, 9, 10 };
            Console.WriteLine("Enter number: ");
            int num;
            if (int.TryParse(Console.ReadLine(), out num))
            {
                int count = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] < num)
                    {
                        count++;
                    }
                }
                Console.WriteLine("Count of numbers less than {0} is {1}", num, count);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
