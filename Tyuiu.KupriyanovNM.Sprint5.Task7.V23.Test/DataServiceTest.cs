using Tyuiu.KupriyanovNM.Sprint5.Task7.V23.Lib;
namespace Tyuiu.KupriyanovNM.Sprint5.Task7.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string inputPath = Path.Combine(
                Path.GetTempPath(),
                "InPutDataFileTask7V23_Test.txt");

            File.WriteAllText(
                inputPath,
                "Привет, World! This моя Первая программа.");

            DataService ds = new DataService();
            string outputPath = ds.LoadDataAndSave(inputPath);

            Assert.IsTrue(File.Exists(outputPath));
            Assert.AreEqual(", World! This.", File.ReadAllText(outputPath));

            File.Delete(inputPath);
            File.Delete(outputPath);
        }
    }
}
