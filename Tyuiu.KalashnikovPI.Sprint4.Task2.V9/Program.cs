using Tyuiu.KalashnikovPI.Sprint4.Task2.V9.Lib;
namespace Tyuiu.KalashnikovPI.Sprint4.Task2.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Калашников П. И. | СМАРТБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 4                                                                *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Калашников Павел Ильич | СМАРТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный         *");
            Console.WriteLine("* случайными в диапазоне от 1 до 7 подсчитать произведение четных         *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫНЕ:                                                       *");
            Console.WriteLine("***************************************************************************");

            int len;
            Console.WriteLine("Введите количество элменетов массива: ");
            len = Convert.ToInt32(Console.ReadLine());
            int[] numsArray = new int[len];

            for(int i = 0; i <= len - 1; i++)
            {
                numsArray[i] = rand.Next(1, 7);
            }

            Console.WriteLine();
            Console.WriteLine("массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine(numsArray[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(numsArray);
            Console.WriteLine(res);
        }
    }
}
