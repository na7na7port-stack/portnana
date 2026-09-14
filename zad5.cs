/*
using System;

int[,] matrix = new int[3, 3];

Console.WriteLine("Введите элементы матрицы 3x3:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Элемент [{i + 1}][{j + 1}]: ");
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}


int[,] transposed = new int[3, 3];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        transposed[j, i] = matrix[i, j];
    }
}


Console.WriteLine("\nБыло:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("\nСтало:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(transposed[i, j] + " ");
    }
    Console.WriteLine();
}
*/