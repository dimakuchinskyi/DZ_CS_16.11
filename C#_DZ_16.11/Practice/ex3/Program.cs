namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num3: ");
            int num3 = int.Parse(Console.ReadLine());

            int[] arr = { 2, 3, 334, 5454, 2, 3, 344, 65, 76, 90, 2, 3, 334, };

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num1 && arr[i + 1] == num2 && arr[i+2] == num3)
                {
                    count++;
                }
            }
            Console.WriteLine($"Number of repetitions of the sequence {num1}, {num2}, {num3}: " + count);
        }
    }
}
