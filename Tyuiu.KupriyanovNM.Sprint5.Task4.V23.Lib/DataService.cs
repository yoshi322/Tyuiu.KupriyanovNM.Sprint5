using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KupriyanovNM.Sprint5.Task4.V23.Lib
{
    public class DataService : ISprint5Task4V23
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path).Trim();
            strX = strX.Replace(".", ",");
            double x = Convert.ToDouble(strX);

            double y = Math.Pow(x, -3) + 2 + Math.Cos(x);
            return Math.Round(y, 3);
        }
    }
}
