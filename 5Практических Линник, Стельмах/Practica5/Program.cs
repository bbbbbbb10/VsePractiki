class Program
{
    static void Main(String[] args)
    {
        int[] numbers = { 5, 12, 8, 3, 9, 7, 2, 15, 10, 6 };

        int maxElement = numbers.Max();
        Console.WriteLine($"Максимальный элемент: {maxElement}");

        foreach (int number in numbers)
        {
            int difference = maxElement - number;
            Console.WriteLine($"Разница между {maxElement} и {number}: {difference}");
        }
    }
}
