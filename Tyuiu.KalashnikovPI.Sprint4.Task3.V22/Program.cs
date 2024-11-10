﻿using System.Runtime.InteropServices;
using Tyuiu.KalashnikovPI.Sprint4.Task3.V22.Lib;
namespace Tyuiu.KalashnikovPI.Sprint4.Task3.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Калашников П. И. | СМАРТБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 4                                                                *");
            Console.WriteLine("* Тема: двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Калашников Павел Ильич | СМАРТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 4 до 9. Найдите максимальный     *");
            Console.WriteLine("* элемент в первой строке массива                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫНЕ:                                                       *");
            Console.WriteLine("***************************************************************************");

            int[,] mtrx = new int[5, 5] { { 4, 4, 7, 8, 9, }, { 9, 5, 9, 7, 8, }, { 7, 4, 9, 4, 6, }, { 4, 4, 7, 4, 4, }, { 4, 5, 8, 6, 7, } };
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"{mtrx[i, j]} \t");
                }

                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(mtrx);
            Console.WriteLine("Максимальный элемент в первой строке массива " + res);

        }
    }
}
