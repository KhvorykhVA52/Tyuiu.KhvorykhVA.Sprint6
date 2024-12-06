using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhvorykhVA.Sprint6.Task1.V18.Lib
{
    public class DataService : ISprint6Task1V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] values = new double[length];

            for (int i = 0; i < length; i++)
            {
                int x = startValue + i;
                if (3 * x + 1.2 == 0)
                {
                    values[i] = 0; 
                }
                else
                {
                    double y = (2 * Math.Sin(x)) / (3 * x + 1.2) + Math.Cos(x) - 7 * Math.Pow(x, 2);
                    values[i] = Math.Round(y, 2);
                }
            }

            return values;
        }
    }
}
