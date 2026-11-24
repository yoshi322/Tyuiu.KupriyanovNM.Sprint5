using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KupriyanovNM.Sprint5.Task0.V10.Lib
{
    public class DataService : ISprint5Task0V10
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            double y = 1.6 * Math.Pow(x, 3) - 2.1 * Math.Pow(x, 2) + 7 * x;
            y = Math.Round(y, 3);

            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
