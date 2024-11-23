static void Main()
{
    Console.OutputEncoding = System.Text.Encoding.GetEncoding(1251);
    int[] arr = { 1, 2, 2, 3, 4, 4, 5, 6, 7 };
    var result = CountEvenOddUnique(arr);
    Console.WriteLine($"Кількість парних чисел: {result.Item1}");
    Console.WriteLine($"Кількість непарних чисел: {result.Item2}");
    Console.WriteLine($"Кількість унікальних чисел: {result.Item3}");
}
static Tuple<int, int, int> CountEvenOddUnique(int[] arr)
{
    int evenCount = 0;
    int oddCount = 0;
    int uniqueCount = 0;
    bool[] isUnique = new bool[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            evenCount++;
        else
            oddCount++;
        bool isDuplicate = false;
        for (int j = 0; j < i; j++)
        {
            if (arr[i] == arr[j])
            {
                isDuplicate = true;
                break;
            }
        }
        if (!isDuplicate)
        {
            uniqueCount++;
        }
    }
    return Tuple.Create(evenCount, oddCount, uniqueCount);
}