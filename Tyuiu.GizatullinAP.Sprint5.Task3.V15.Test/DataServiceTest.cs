using Tyuiu.GizatullinAP.Sprint5.Task3.V15.Lib;
namespace Tyuiu.GizatullinAP.Sprint5.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\coc19\AppData\Local\Temp\OutPutFileTask3.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}