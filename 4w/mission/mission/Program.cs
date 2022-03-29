class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[5];

        for (int i = 0; i < array.Length; ++i)
        {
            Console.WriteLine($"{i}번째 번호");
            array[i] = int.Parse(Console.ReadLine());
        }

        Calculate(array);
    }

    static void Calculate(int [] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++) sum += array[i];

        Console.WriteLine($"합: {sum}");
        Console.WriteLine($"평균: {(double) sum / array.Length}");
    }
}