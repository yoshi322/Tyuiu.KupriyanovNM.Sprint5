using Mono.Cecil;
using Tyuiu.KupriyanovNM.Sprint5.Task0.V10.Lib;
namespace Tyuiu.KupriyanovNM.Sprint5.Task0.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.KupriyanovNM.Sprint5\Tyuiu.KupriyanovNM.Sprint5.Task0.V10\bin\Debug\net8.0\OutPutFileTask0.txt";

            DataService ds = new DataService();
            ds.SaveToFileTextData(2);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
