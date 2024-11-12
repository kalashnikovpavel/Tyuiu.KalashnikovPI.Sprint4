using Tyuiu.KalashnikovPI.Sprint4.Task6.V1.Lib;
namespace Tyuiu.KalashnikovPI.Sprint4.Task6.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rand = new Random();
            Console.Title = "Спринт #4 | Выполнил: Калашников П. И. | СМАРТБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 4                                                                *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Калашников Павел Ильич | СМАРТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных используя класс Array подсчитайте количество*");
            Console.WriteLine("* элементов, длина которых больше 6.                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫНЕ:                                                       *");
            Console.WriteLine("***************************************************************************");

            var fruit = new string[] { "Яблоко", "Банан", "Вишня", "Драгонфрут", "Бузина", "Инжир", "Виноград" };
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < fruit.Length - 1; i++)
            { 
                Console.WriteLine(fruit[i]);
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Колличество элементов, длина которых больше 6 = ");
            int nums = ds.Calculate(fruit);
            Console.WriteLine(nums);
        }
    }
}
