using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KupriyanovNM.Sprint5.Task5.V6.Lib
{
    public class DataService : ISprint5Task5V6
    {
        public double LoadFromDataFile(string path)
        {
            double sum = 0;
            int count = 0;

            string fileData = File.ReadAllText(path);
            string[] valArray = fileData.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string val in valArray)
            {
                string tempVal = val.Replace(".", ",");
                if (double.TryParse(tempVal, out double number))
                {
                    sum += number;
                    count++;
                }
            }

            if (count == 0)
            {
                return 0;
            }

            return Math.Round(sum / count, 3);
        }
    }
}
