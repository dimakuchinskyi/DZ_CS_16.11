using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int[,] array = new int[5, 5];
            Random rand = new Random();

            Console.WriteLine("Масив 5x5:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = rand.Next(-100, 101);
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int min = array[0, 0], max = array[0, 0];
            int minRow = 0, minCol = 0, maxRow = 0, maxCol = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        minRow = i;
                        minCol = j;
                    }
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }

            Console.WriteLine($"\nМінімальний елемент: {min} на позиції ({minRow}, {minCol})");
            Console.WriteLine($"Максимальний елемент: {max} на позиції ({maxRow}, {maxCol})");

            int sum = 0;

            if (minRow == maxRow)
            {
                int startCol = Math.Min(minCol, maxCol) + 1;
                int endCol = Math.Max(minCol, maxCol);

                for (int col = startCol; col < endCol; col++)
                {
                    sum += array[minRow, col];
                }
            }
            else if (minCol == maxCol)
            {
                int startRow = Math.Min(minRow, maxRow) + 1;
                int endRow = Math.Max(minRow, maxRow);

                for (int row = startRow; row < endRow; row++)
                {
                    sum += array[row, minCol];
                }
            }
            else
            {
                for (int i = Math.Min(minRow, maxRow) + 1; i < Math.Max(minRow, maxRow); i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        sum += array[i, j];
                    }
                }
                for (int j = Math.Min(minCol, maxCol) + 1; j < Math.Max(minCol, maxCol); j++)
                {
                    sum += array[Math.Max(minRow, maxRow), j];
                }
            }

            Console.WriteLine($"\nСума елементів між мінімальним і максимальним елементами: {sum}");
        }
    }
}
