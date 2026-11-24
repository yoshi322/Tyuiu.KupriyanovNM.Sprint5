using Tyuiu.KupriyanovNM.Sprint5.Task1.V17.Lib;
namespace Tyuiu.KupriyanovNM.Sprint5.Task1.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Куприянов Н. М. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Куприянов Никита Максимович | ИБКСб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение.(произвести табулирование) f(x) на заданном диапазоне    *");
            Console.WriteLine("* [-5;5] с шагом 1. Произвести проверку деления на ноль. При делении на   *");
            Console.WriteLine("* ноль вернуть значение 0. Значения округлить до двух знаков после запятой*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.WriteLine();
            Console.WriteLine("+---------+---------+");
            Console.WriteLine("|    X    |   f(x)  |");
            Console.WriteLine("+---------+---------+");

            string[] lines = File.ReadAllLines(res);
            int currentX = startValue;

            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine("|{0,6:d}   | {1,7} |", currentX, lines[i]);
                currentX++;
            }

            Console.WriteLine("+---------+---------+");

            Console.ReadKey();
        }
    }
}
