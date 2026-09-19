/*
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0) return;

        int[] array = new int[n];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите элемент {i}: ");
            array[i] = int.Parse(Console.ReadLine());
            sum += array[i];
        }

        Console.WriteLine("\nМассив в обратном порядке:");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        double average = (double)sum / n;
        int closest = array[0];
        double minDifference = Math.Abs(array[0] - average);

        foreach (int num in array)
        {
            double diff = Math.Abs(num - average);
            if (diff < minDifference)
            {
                minDifference = diff;
                closest = num;
            }
        }

        Console.WriteLine($"\nСреднее арифметическое: {average:F2}");
        Console.WriteLine($"Число, максимально близкое к среднему: {closest}");
    }
}
*/