using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleListProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<int> numbers = new List<int>(); // Створення списку цілих чисел

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Виберіть операцію:");
                Console.WriteLine("1. Додати елемент");
                Console.WriteLine("2. Видалити елемент");
                Console.WriteLine("3. Оновити елемент");
                Console.WriteLine("4. Показати список");
                Console.WriteLine("5. Вийти");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Введено некоректне значення. Спробуйте ще раз.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Введіть ціле число для додавання:");
                        int numToAdd;
                        if (int.TryParse(Console.ReadLine(), out numToAdd))
                        {
                            numbers.Add(numToAdd); // Додавання елемента до списку
                            Console.WriteLine("Елемент успішно додано до списку.");
                        }
                        else
                        {
                            Console.WriteLine("Введено некоректне число. Додавання скасовано.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Введіть індекс елемента, який потрібно видалити:");
                        int indexToRemove;
                        if (int.TryParse(Console.ReadLine(), out indexToRemove) && indexToRemove >= 0 && indexToRemove < numbers.Count)
                        {
                            numbers.RemoveAt(indexToRemove); // Видалення елемента зі списку за індексом
                            Console.WriteLine("Елемент успішно видалено зі списку.");
                        }
                        else
                        {
                            Console.WriteLine("Некоректний індекс або вихід за межі списку. Видалення скасовано.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Введіть індекс елемента, який потрібно оновити:");
                        int indexToUpdate;
                        if (int.TryParse(Console.ReadLine(), out indexToUpdate) && indexToUpdate >= 0 && indexToUpdate < numbers.Count)
                        {
                            Console.WriteLine("Введіть нове значення для оновлення:");
                            int newNumber;
                            if (int.TryParse(Console.ReadLine(), out newNumber))
                            {
                                numbers[indexToUpdate] = newNumber; // Оновлення елемента у списку за індексом
                                Console.WriteLine("Елемент успішно оновлено.");
                            }
                            else
                            {
                                Console.WriteLine("Введено некоректне число. Оновлення скасовано.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Некоректний індекс або вихід за межі списку. Оновлення скасовано.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Елементи у списку:");
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            Console.WriteLine($"[{i}] {numbers[i]}");
                        }
                        break;

                    case 5:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Некоректний вибір операції. Спробуйте ще раз.");
                        break;
                }

                Console.WriteLine();
            }

            Console.WriteLine("Програма завершила роботу.");
        }
    }
}
