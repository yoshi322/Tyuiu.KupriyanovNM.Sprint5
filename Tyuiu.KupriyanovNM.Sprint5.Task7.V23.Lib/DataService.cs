using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KupriyanovNM.Sprint5.Task7.V23.Lib
{
    public class DataService : ISprint5Task7V23
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);

            string result = Regex.Replace(text, @"[А-Яа-яЁё]+", "");
            result = Regex.Replace(result, @"\s+", " ");
            result = Regex.Replace(result, @"\s+([,.!?;:])", "$1");
            result = result.Trim();

            string pathSaveFile = Path.Combine(
                Path.GetTempPath(), "OutPutFileTask7.txt");

            File.WriteAllText(pathSaveFile, result);

            return pathSaveFile;
        }
    }
}
