using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[,] { { 1, -2, 3 }, { -4, 5, 6 }, { 7, 8, 9 } };
        int sum = 0;
        int minSum = int.MaxValue;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool hasNegative = false;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < 0)
                {
                    hasNegative = true;
                    break;
                }

                sum += matrix[i, j];
            }

            if (!hasNegative && sum > 0)
            {
                Console.WriteLine("Sum of elements in row {0}: {1}", i + 1, sum);
            }

            sum = 0;
        }

        for (int i = 1 - matrix.GetLength(0); i < matrix.GetLength(1); i++)
        {
            sum = 0;

            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                int k = i + j;

                if (k >= 0 && k < matrix.GetLength(1))
                {
                    sum += matrix[j, k];
                }
            }

            if (sum < minSum)
            {
                minSum = sum;
            }
        }

        Console.WriteLine("Minimum sum of elements in diagonals parallel to main diagonal: {0}", minSum);
    }
}
