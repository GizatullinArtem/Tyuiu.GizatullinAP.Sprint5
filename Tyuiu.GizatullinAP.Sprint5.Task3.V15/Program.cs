using Tyuiu.GizatullinAP.Sprint5.Task3.V15.Lib;
namespace Tyuiu.GizatullinAP.Sprint5.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил Гизатуллин А. П.| ИСПб-24-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #5                                                                   *");
            Console.WriteLine("* Тема: Базовые навыки работы в с#                                            *");
            Console.WriteLine("* Задание #4                                                                  *");
            Console.WriteLine("* Вариант #15                                                                 *");
            Console.WriteLine("* Выполнил Гизатуллин Артём Павлович | ИСПб-24-1                              *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Дано выражение , вычислить его значение при x = 5, результат сохранить      *");
            Console.WriteLine("* в бинарный файл OutPutFileTask3.bin и вывести на консоль. Округлить до трёх *");
            Console.WriteLine("* знаков после запятой                                                        *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            int x = 5;
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан");
            Console.ReadKey();
        }
    }
}