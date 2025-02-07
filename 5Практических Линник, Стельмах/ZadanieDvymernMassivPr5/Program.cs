
class Program
{
    static void Main()
    {
        int sigma = 6;
        int[,] massiv = new int[sigma, sigma];

        for (int i = 0; i < sigma; i++)
        {
            for (int j = 0; j < sigma; j++)
            {
                massiv[i, j] = (i + j) % 2;
                Console.Write(massiv[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}