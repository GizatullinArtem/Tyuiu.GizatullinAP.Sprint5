using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.GizatullinAP.Sprint5.Task1.V17.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestSaveToFileTextData()
    {
        DataService ds = new DataService();
        string expectedFilePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

        string filePath = ds.SaveToFileTextData(-5, 5);

        Assert.AreEqual(expectedFilePath, filePath); 
        Assert.IsTrue(File.Exists(filePath)); 


        string[] lines = File.ReadAllLines(filePath);

        Assert.AreEqual(11, lines.Length); 
    }
}