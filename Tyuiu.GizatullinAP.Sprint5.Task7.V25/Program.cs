﻿using Tyuiu.GizatullinAP.Sprint5.Task7.V25.Lib;
    DataService ds = new DataService();
    string path = @"C:\DataSprint5\InPutDataFileTask7V25.txt";
    string pathSavefile = Path.Combine(Convert.ToString(Path.GetTempPath()), "OutPutDataFileTask7V25.txt");
    string res = ds.LoadDataAndSave(path);
        Console.Title = "Спринт #5 | Гизатуллин А. П. | ИСПб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #25                                                             *");
        Console.WriteLine("* Выполнил: Гизатуллин Артём Пвалович | ИСПб-24-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine(@"* Дан файл С:\\DataSprint5\\InPutDataFileTask7V25.txt (файл взять из     *");
        Console.WriteLine(@"* архива согласно вашему варианту. Создать папку в ручную С:\DataSprint5\*");
        Console.WriteLine("* и скопировать в неё файл) в котором есть набор символьных данных.Удалить*");
        Console.WriteLine("* все английские слова из файла.Полученный результат сохранить в файл     *");
        Console.WriteLine("* OutPutDataFileTask7V25.txt.                                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine($"Данные находятся в файле: {path}                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine($"Находится в файле: {res}");
        Console.WriteLine("***************************************************************************");
        Console.ReadKey();  