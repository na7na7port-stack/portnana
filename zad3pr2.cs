/*
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        HashSet<int> seen = new HashSet<int>();

        Console.WriteLine("Вводите числа по одному. При вводе повтора программа завершится:");

        while (true)
        {
            int num = int.Parse(Console.ReadLine());
            if (seen.Contains(num))
            {
                Console.WriteLine($"\nОбнаружено повторение числа: {num}. Ввод остановлен.");
                break;
            }
            numbers.Add(num);
            seen.Add(num);
        }

        Console.WriteLine("\nИтоговый массив уникальных чисел:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
*/