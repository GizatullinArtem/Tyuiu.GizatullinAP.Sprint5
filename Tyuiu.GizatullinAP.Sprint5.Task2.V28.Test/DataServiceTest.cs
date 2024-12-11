using System.IO;
using Tyuiu.GizatullinAP.Sprint5.Task2.V28.Lib;
namespace Tyuiu.GizatullinAP.Sprint5.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\coc19\AppData\Local\Temp\OutPutFileTask2.csv";
            string tempPath = Path.GetTempPath();


            string fileName = "OutOutFileTask0.txt";
            string p = Path.Combine(tempPath, fileName);

            FileInfo fileInfo = new FileInfo(path);


            bool fileExists = fileInfo.Exists;


            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}