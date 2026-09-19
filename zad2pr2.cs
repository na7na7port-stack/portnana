/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество студентов: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите количество предметов: ");
        int m = int.Parse(Console.ReadLine());

        int[,] grades = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nЗаполнение оценок для студента №{i + 1}:");
            for (int j = 0; j < m; j++)
            {
                Console.Write($"  Предмет №{j + 1}: ");
                grades[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nСредние оценки студентов:");
        for (int i = 0; i < n; i++)
        {
            int studentSum = 0;
            for (int j = 0; j < m; j++)
            {
                studentSum += grades[i, j];
            }
            double studentAverage = (double)studentSum / m;
            Console.WriteLine($"Студент №{i + 1}: {studentAverage:F2}");
        }
    }
}
*/