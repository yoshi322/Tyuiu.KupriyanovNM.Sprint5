using Tyuiu.KupriyanovNM.Sprint5.Task4.V23.Lib;
namespace Tyuiu.KupriyanovNM.Sprint5.Task4.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask4V23.txt";

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "3.47");
            }

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
