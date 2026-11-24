using Tyuiu.KupriyanovNM.Sprint5.Task6.V26.Lib;

namespace Tyuiu.KupriyanovNM.Sprint5.Task6.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask6V26.txt";

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "Это? Не просто? Строка? С восклицательными знаками???");
            }

            var res = ds.LoadFromDataFile(path);
            int wait = 6;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask6V26.txt";

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "Это? Не просто? Строка? С восклицательными знаками???");
            }

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
