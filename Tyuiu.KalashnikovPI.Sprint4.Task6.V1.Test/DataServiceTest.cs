using Tyuiu.KalashnikovPI.Sprint4.Task6.V1.Lib;
namespace Tyuiu.KalashnikovPI.Sprint4.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var mas = new string[] { "Яблоко", "Банан", "Вишня", "Драгонфрут", "Бузина", "Инжир", "Виноград" };
            int res = ds.Calculate(mas);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}