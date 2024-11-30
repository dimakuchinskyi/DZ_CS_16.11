using System;
namespace ConsoleApp5;

class Program
    {
        static void Main(string[] args)
        {
        int[,] mas1 =
            {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        int min = mas1[0, 0];
        int max = mas1[0, 0];
        foreach (int i in mas1)
        {
            if(i < min)
            {
                min = i;
            }
            if (i > max)
            {
                max = i;
            }
        }
        Console.WriteLine("Минимальное значение: " + min);
        Console.WriteLine("Максимальное значение: " + max);
    }
    }


