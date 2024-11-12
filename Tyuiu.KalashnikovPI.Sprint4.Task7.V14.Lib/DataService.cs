﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KalashnikovPI.Sprint4.Task7.V14.Lib
{
    public class DataService : ISprint4Task7V14
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mtrx = new int[n, m];

            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }

            int sum = 0;
            for(int i = 0;i < n; i++)
            {
                for (int j = 0;j < m; j++)
                {
                    if (mtrx[i,j] % 2 != 0)
                    {
                        sum += mtrx[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
