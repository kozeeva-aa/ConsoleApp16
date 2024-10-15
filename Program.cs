// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//1.Записать что - то в файл, прочитать что-то из файла
//можно сделать что-то вроде простого блокнота, который записывает в файл всё то что пользователь туда записывает

using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Запрос пути к файлу у пользователя
        Console.WriteLine("Укажите путь к файлу. Если такого файла нет, он будет создан:");
        string filePath = Console.ReadLine();


        // построчный ввод текста
        while (true)
        {
            Console.WriteLine("Введенный текст будет добавлен в конец файла, Enter - переход на новую строку, q - выход:");
            string input = Console.ReadLine();

            //string finalContent = File.ReadAllText(filePath);
            //Console.WriteLine(finalContent);

            // Проверка на ввод команды для выхода
            if (input.ToLower() == "q")
            {
                break;
            }

            // Добавление текста в файл
            File.AppendAllText(filePath, input + Environment.NewLine);

            Console.WriteLine($"Текст успешно добавлен в файл {Path.GetFileName(filePath)}.");

        }

        //вывод результата
        string finalContent = File.ReadAllText(filePath);
        Console.WriteLine(finalContent);
    }
}




