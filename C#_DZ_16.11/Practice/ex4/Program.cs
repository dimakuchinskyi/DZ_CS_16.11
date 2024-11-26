using System;
namespace ex4;
class Program
{
    static void Main(string[] args)
    {
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 3, 4, 5, 6, 7 };
        int[] commonElements = new int[Math.Min(array1.Length, array2.Length)];
        int index = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            for (int j = 0; j < array2.Length; j++)
            {
                if (array1[i] == array2[j])
                {
                    bool isUnique = true;
                    for (int k = 0; k < index; k++)
                    {
                        if (commonElements[k] == array1[i])
                        {
                            isUnique = false;
                            break;
                        }
                    }
                    if (isUnique)
                    {
                        commonElements[index++] = array1[i];
                    }
                }
            }
        }
        Console.WriteLine("Спільні елементи без повторень:");
        for (int i = 0; i < index; i++)
        {
            Console.Write(commonElements[i] + " ");
        }
    }
}
