/*
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        while (true)
        {
            Console.WriteLine("\nВыберите действие: 1 - Добавить, 2 - Поиск, 3 - Просмотр всех, 'выход' - Завершить");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "выход")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            if (input == "1")
            {
                Console.Write("Введите имя: ");
                string name = Console.ReadLine();
                Console.Write("Введите номер телефона: ");
                string phone = Console.ReadLine();

                phoneBook[name] = phone;
                Console.WriteLine("Контакт успешно сохранен.");
            }
            else if (input == "2")
            {
                Console.Write("Введите имя для поиска: ");
                string name = Console.ReadLine();

                if (phoneBook.TryGetValue(name, out string phone))
                {
                    Console.WriteLine($"Найденный номер: {phone}");
                }
                else
                {
                    Console.WriteLine("Контакт с таким именем отсутствует.");
                }
            }
            else if (input == "3")
            {
                Console.WriteLine("\nВсе контакты в книге:");
                foreach (var contact in phoneBook)
                {
                    Console.WriteLine($"Имя: {contact.Key} | Телефон: {contact.Value}");
                }
            }
            else
            {
                Console.WriteLine("Команда не распознана. Попробуйте еще раз.");
            }
        }
    }
}
*/