using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            
            double startdistance = 10; 
            double totaldistance = 0; 
            double dailydistance = startdistance; 

            for (int day = 1; day <= 7; day++)
            {
                totaldistance += dailydistance; //общ к дневн
                dailydistance *= 1.10;
            }

            Console.WriteLine("Суммарный путь пробежанный спортсменом за 7 дней = {0} км", totaldistance);
        }
    }
}





