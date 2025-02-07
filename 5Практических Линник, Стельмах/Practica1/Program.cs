using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Введите y: ");
        double y = double.Parse(Console.ReadLine());
        double result = Math.Pow(2, -x) - Math.Cos(x) + Math.Sin(2 * x * y);

        Console.WriteLine("Результат:" + result);
    }
}
