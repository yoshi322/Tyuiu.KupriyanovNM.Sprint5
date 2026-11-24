using Tyuiu.KupriyanovNM.Sprint5.Task7.V23.Lib;
namespace Tyuiu.KupriyanovNM.Sprint5.Task7.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string inputPath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "InPutDataFileTask7V23.txt");
            Console.Title = "Спринт #5 | Выполнил: Куприянов Н. М. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Куприянов Никита Максимович | ИБКСб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл в котором есть набор символьных данных.Удалить все русские     *");
            Console.WriteLine("* слова из файла.Полученный результат сохранить в файл                    *");
            Console.WriteLine("* OutPutDataFileTask7V23.txt.                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Входной файл: " + inputPath);

            string outputPath = ds.LoadDataAndSave(inputPath);

            Console.WriteLine();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результат сохранён в файл: " + outputPath);
            Console.WriteLine("Текст: " + ", " + File.ReadAllText(outputPath));

            Console.ReadKey();
        }
    }
}
