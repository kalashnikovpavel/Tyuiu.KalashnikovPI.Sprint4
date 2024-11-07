using Tyuiu.KalashnikovPI.Sprint4.Task0.V30.Lib;
namespace Tyuiu.KalashnikovPI.Sprint4.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            int res = ds.GetSumEvenArrEl(numsArray);
            int wait = 30;
            Assert.AreEqual(wait, res);
        }
    }
}