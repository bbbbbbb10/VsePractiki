using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("введите натуральное число n:");
        int n = Convert.ToInt32(Console.ReadLine());

        double S = 0;

        for (int i = 0; i <= n; i++)
        {

            S += Math.Pow(i, 7); 
        }
        Console.WriteLine("S =" + S);
    }


}  

