using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhvorykhVA.Sprint6.Task1.V18.Lib
{
    public class DataService : ISprint6Task1V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = 0;
            for (int i = startValue; i <= stopValue; i++) count++;

            double[] mass = new double[count];
            int k = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                if (3 * i + 1.2 == 0)
                {
                    mass[k] = 0;
                    continue;
                }

                mass[k] = Math.Round((((2 * Math.Sin(i)) / (3 * i + 1.2))) + Math.Cos(i) - 7 * i * 2, 2);
                k++;
            }
            return mass;
        }
    }
}