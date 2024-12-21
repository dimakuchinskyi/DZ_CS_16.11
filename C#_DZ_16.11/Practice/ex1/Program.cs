namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random(DateTime.Now.Millisecond);
            Console.WriteLine("Enter the lower bound of the random number: ");
            var lowerMaxRandomBound = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the upper bound of the random number: ");
            var upperMaxRandomBound = Convert.ToInt32(Console.ReadLine());

            if (lowerMaxRandomBound > upperMaxRandomBound)
            {
                (lowerMaxRandomBound, upperMaxRandomBound) = (upperMaxRandomBound, lowerMaxRandomBound);
            }

            Console.WriteLine("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(lowerMaxRandomBound, upperMaxRandomBound + 1);
            }

            Console.WriteLine("The generated array is: ");
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            int evenCount = 0;
            int oddCount = 0;
            foreach (int number in arr)
            {
                if (number % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            int uniqueCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool isUnique = true;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    uniqueCount++;
                }
            }

            Console.WriteLine($"Par: {evenCount}");
            Console.WriteLine($"Ne pa: {oddCount}");
            Console.WriteLine($"Uniq: {uniqueCount}");
        }
    }
 }
