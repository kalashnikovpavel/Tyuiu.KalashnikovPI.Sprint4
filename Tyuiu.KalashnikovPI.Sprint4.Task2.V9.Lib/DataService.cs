using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KalashnikovPI.Sprint4.Task2.V9.Lib
{
    public class DataService : ISprint4Task2V9
    {
        public int Calculate(int[] array)
        {
            int nums = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    nums *= array[i];
                }
            }
            return nums;
        }
    }
}
