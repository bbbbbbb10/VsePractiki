using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите четырехзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 1000 || number > 9999)
        {
            Console.WriteLine("Ошибка: введите четырехзначное число.");
            return;
        }

        int product = 1;
        while (number > 0)
        {
            product *= number % 10; 
            number /= 10; 
        }

        Console.WriteLine("Произведение цифр: " + product);
    }
}
