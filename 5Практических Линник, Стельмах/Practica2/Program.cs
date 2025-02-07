using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double res = 0;
            if (x <= 0) 
                res = 0;
               
            else if(0 < x || x <= 1) {
                res = x;
            }
            if (x > 1)
            {
                res = Math.Pow(x, 4);
            }
            
            Console.WriteLine("для x = {0}", x);
            Console.WriteLine("результат = " + res);
        }
    }
}

