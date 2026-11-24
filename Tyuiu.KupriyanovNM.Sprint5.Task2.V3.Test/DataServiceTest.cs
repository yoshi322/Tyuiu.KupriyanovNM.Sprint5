using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.KupriyanovNM.Sprint5.Task2.V3.Lib;
namespace Tyuiu.KupriyanovNM.Sprint5.Task2.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask2.csv";

            DataService ds = new DataService();

            int[,] mtrx = new int[3, 3] {
        { 5, 9, 1 },
        { 1, 3, 9 },
        { 1, 2, 2 }
    };

            ds.SaveToFileTextData(mtrx);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
