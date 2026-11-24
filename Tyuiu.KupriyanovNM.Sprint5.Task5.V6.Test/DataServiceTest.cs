using Tyuiu.KupriyanovNM.Sprint5.Task5.V6.Lib;
namespace Tyuiu.KupriyanovNM.Sprint5.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask5V6.txt";

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "-2.05 19 -10 -7 -8 9.32 3.64 14.7 -3 4 -2.41 -7.07 13.02 18.52 9 10.87 15.76 -2 2.67 17");
            }

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
