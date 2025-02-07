using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число с: ");
        double c = Convert.ToDouble(Console.ReadLine());

        int res = 0;

        if (a % 1 == 0)
            res++;
        if (b % 1 == 0) 
            res++;
        if (c % 1 == 0) 
            res++;

        Console.WriteLine($"Количество целых чисел: {res}");
    }
}

