using Tyuiu.KalashnikovPI.Sprint4.Task5.V9.Lib;
namespace Tyuiu.KalashnikovPI.Sprint4.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { -2, 2, -4, 1, 0 }, { 0, -2, 0, -4, -4 }, { 1, -1, 4, -4, -4 }, { 3, 1, 0, 4, -1 }, { -3, 3, -2, -1, 3 } };
            int res = ds.Calculate(mas2);
            int wait = 9;
            Assert.AreEqual(res, wait);
        }
    }
}