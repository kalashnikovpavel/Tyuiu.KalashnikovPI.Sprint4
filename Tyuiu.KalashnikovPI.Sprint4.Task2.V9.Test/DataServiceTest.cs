using Tyuiu.KalashnikovPI.Sprint4.Task2.V9.Lib;
namespace Tyuiu.KalashnikovPI.Sprint4.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            int res = ds.Calculate(numsArray);
            int wait = 645120;
            Assert.AreEqual(wait, res);
        }
    }
}