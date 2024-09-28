using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество строк (m): ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов (n): ");
        int n = int.Parse(Console.ReadLine());

        double[,] matrix = new double[m, n];
        Random random = new Random();

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = random.NextDouble() * 20 - 10;
                Console.Write(matrix[i, j].ToString("F2") + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nНомера столбцов, содержащих только отрицательные элементы:");
        bool hasNegativeOnly;

        for (int j = 0; j < n; j++)
        {
            hasNegativeOnly = true;

            for (int i = 0; i < m; i++)
            {
                if (matrix[i, j] >= 0)
                {
                    hasNegativeOnly = false;
                    break;
                }
            }

            if (hasNegativeOnly)
            {
                Console.WriteLine($"Столбец {j + 1}");
            }
        }
    }
}
