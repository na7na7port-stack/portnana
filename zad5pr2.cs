using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> products = new Dictionary<string, int>();

        Console.WriteLine("Вводите названия продуктов. Для выхода введите 'выход':");

        while (true)
        {
            Console.Write("Ввод: ");
            string input = Console.ReadLine().Trim();

            if (input.ToLower() == "выход")
            {
                break;
            }

            if (products.ContainsKey(input))
            {
                products[input] += 1;
            }
            else
            {
                products[input] = 1;
            }

            Console.WriteLine("Текущее состояние словаря:");
            foreach (var item in products)
            {
                Console.WriteLine($"{{{item.Key} : {item.Value}}}");
            }
            Console.WriteLine();
        }
    }
}