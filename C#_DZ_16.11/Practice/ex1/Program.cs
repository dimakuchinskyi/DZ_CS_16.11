using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            
            double[] A = new double[5];
            double[,] B = new double[3, 4];

            Console.WriteLine("Введіть 5 елементів для масиву A:");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Convert.ToDouble(Console.ReadLine());
            }

            Random rand = new Random();
            Console.WriteLine("\nМасив B (3 рядки, 4 стовпці):");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = rand.NextDouble() * 100;
                    Console.Write($"{B[i, j]:F2} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nМасив A:");
            foreach (var item in A)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            double max = A[0], min = A[0], sum = 0, product = 1, evenSum = 0;
            double oddColumnsSum = 0;

            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
                product *= A[i];
                if (A[i] > max) max = A[i];
                if (A[i] < min) min = A[i];
                if (A[i] % 2 == 0) evenSum += A[i];
            }

            for (int j = 0; j < 4; j++)
            {
                if (j % 2 != 0) 
                {
                    for (int i = 0; i < 3; i++)
                    {
                        oddColumnsSum += B[i, j];
                    }
                }
            }

            Console.WriteLine($"\nМаксимальний елемент: {max}");
            Console.WriteLine($"Мінімальний елемент: {min}");
            Console.WriteLine($"Загальна сума елементів масиву A: {sum}");
            Console.WriteLine($"Загальний добуток елементів масиву A: {product}");
            Console.WriteLine($"Сума парних елементів масиву A: {evenSum}");
            Console.WriteLine($"Сума непарних стовпців масиву B: {oddColumnsSum}");
        }
    }
}
