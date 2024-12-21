using System.Text;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть кількість рядків та стовпців для матриці 1:");
            int rows1 = int.Parse(Console.ReadLine());
            int cols1 = int.Parse(Console.ReadLine());

            int[,] matrix1 = new int[rows1, cols1];
            Console.WriteLine("Введіть елементи для матриці 1:");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Введіть кількість рядків та стовпців для матриці 2:");
            int rows2 = int.Parse(Console.ReadLine());
            int cols2 = int.Parse(Console.ReadLine());

            int[,] matrix2 = new int[rows2, cols2];
            Console.WriteLine("Введіть елементи для матриці 2:");
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Введіть число для множення на матрицю 1:");
            int scalar = int.Parse(Console.ReadLine());
            int[,] multipliedMatrix = MultiplyMatrixByScalar(matrix1, scalar);
            Console.WriteLine("Результат множення матриці на число:");
            PrintMatrix(multipliedMatrix);

            if (rows1 == rows2 && cols1 == cols2)
            {
                int[,] sumMatrix = AddMatrices(matrix1, matrix2);
                Console.WriteLine("Результат додавання матриць:");
                PrintMatrix(sumMatrix);
            }
            else
            {
                Console.WriteLine("Матриці не можна додавати, оскільки їх розміри не співпадають.");
            }

            if (cols1 == rows2)
            {
                int[,] productMatrix = MultiplyMatrices(matrix1, matrix2);
                Console.WriteLine("Результат добутку матриць:");
                PrintMatrix(productMatrix);
            }
            else
            {
                Console.WriteLine("Матриці не можна множити, оскільки кількість стовпців першої матриці не дорівнює кількості рядків другої матриці.");
            }
        }

        static int[,] MultiplyMatrixByScalar(int[,] matrix, int scalar)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j] * scalar;
                }
            }
            return result;
        }

        static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }

        static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            int[,] result = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return result;
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

