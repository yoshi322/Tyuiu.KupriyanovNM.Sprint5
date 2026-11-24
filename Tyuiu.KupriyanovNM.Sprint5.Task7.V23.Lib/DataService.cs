using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KupriyanovNM.Sprint5.Task7.V23.Lib
{
    public class DataService : ISprint5Task7V23
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);

            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7V23.txt";

            string[] words = text.Split(
                new char[] { ' ', '\t', '\r', '\n' },
                StringSplitOptions.RemoveEmptyEntries);

            string result = string.Join(
                " ",
                words.Where(word => !word.Any(
                    symbol => (symbol >= 'А' && symbol <= 'я') ||
                              symbol == 'Ё' ||
                              symbol == 'ё')));

            File.WriteAllText(pathSaveFile, result);

            return pathSaveFile;
        }
    }
}
