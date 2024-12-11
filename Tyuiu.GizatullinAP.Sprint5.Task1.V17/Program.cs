﻿using System;
using System.IO;
using Tyuiu.GizatullinAP.Sprint5.Task1.V17.Lib;

namespace Tyuiu.GizatullinAP.Sprint5.Task1.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Гизатуллин Артём | ИСПб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Табулирование функций                                             *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Гизаутллин Артём Павлович    | ИБКСБ-24-1                     *");
            Console.WriteLine("***************************************************************************");
            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Диапазон: от {startValue} до {stopValue}");
            Console.WriteLine("***************************************************************************");

            try
            {
             
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");
                string res = ds.SaveToFileTextData(startValue, stopValue);

                Console.WriteLine($"Файл: {res}");
                Console.WriteLine("Содержимое файла:");
                Console.WriteLine(File.ReadAllText(res));
                Console.WriteLine("Файл успешно создан!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}