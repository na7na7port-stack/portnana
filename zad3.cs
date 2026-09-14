/*
using System;
using System.Linq;

Console.WriteLine("Введите 7 температур через пробел:");
string input = Console.ReadLine();

double[] temperatures = input
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .ToArray();

if (temperatures.Length != 7)
{
    Console.WriteLine("Ошибка: нужно ввести ровно 7 чисел!");
    return;
}
double average = temperatures.Sum() / temperatures.Length;
Console.WriteLine($"Средняя температура за неделю: {average:F2}");
*/