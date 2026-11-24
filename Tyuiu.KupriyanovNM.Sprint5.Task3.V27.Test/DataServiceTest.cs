using Tyuiu.KupriyanovNM.Sprint5.Task3.V27.Lib;
namespace Tyuiu.KupriyanovNM.Sprint5.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";

            DataService ds = new DataService();
            ds.SaveToFileTextData(3);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
