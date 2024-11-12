using Tyuiu.KalashnikovPI.Sprint4.Task7.V14.Lib;
namespace Tyuiu.KalashnikovPI.Sprint4.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int rows = 3;
            int cols = 4;
            int[,] mtrx = new int[rows, cols];
            string str = "458712659137";
            int res = ds.Calculate(rows, cols, str);
            int wait = 38;
            Assert.AreEqual(wait, res);
        }
    }
}