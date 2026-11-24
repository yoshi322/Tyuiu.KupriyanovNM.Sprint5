using Tyuiu.KupriyanovNM.Sprint5.Task4.V23.Lib;
namespace Tyuiu.KupriyanovNM.Sprint5.Task4.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Куприянов Н. М. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Куприянов Никита Максимович | ИБКСб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Создать папку в ручную и скопировать в неё файл в котором есть          *");
            Console.WriteLine("* вещественное значение. Прочитать значение из файла и подставить вместо  *");
            Console.WriteLine("* Х в формуле. Вычислить значение по формуле (Полученное значение округлит*");
            Console.WriteLine("* до трёх знаков после запятой) и вернуть полученный результат на консоль *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V23.txt";

            if (!File.Exists(path))
            {
                path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask4V23.txt";
            }

            Console.WriteLine("Данные находятся в файле: " + path);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Результат = " + res);

            Console.ReadKey();
        }
    }
}
