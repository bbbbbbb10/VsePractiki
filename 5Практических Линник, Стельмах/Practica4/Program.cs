
class Program
{
    static void Main(String[] args)
    {
        try
        {
            Console.WriteLine("введите число которое вычисляется по формуле: ");
            double x = Convert.ToByte(Console.ReadLine());
            double result =Math.Sqrt(x) * Math.Pow(Math.Cos(x), 2);
            Console.WriteLine($"F(x) = {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка: деление на ноль");
        }
        catch (OverflowException e)
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Произошло исключение: {e.Message}");
        }
        finally
        {
            Console.WriteLine("Вычисления завершены");
        }
    }
}