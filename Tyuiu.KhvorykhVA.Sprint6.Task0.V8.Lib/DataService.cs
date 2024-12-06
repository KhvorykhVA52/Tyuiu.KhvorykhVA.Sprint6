
using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhvorykhVA.Sprint6.Task0.V8.Lib
{
    public class DataService : ISprint6Task0V8
    {
        public double Calculate(int x)
        {
            double y = (Math.Pow(x, 2) - 3) / Math.Sqrt(Math.Pow(x, 2) + 2);
            return Math.Round(y, 3);
        }
    }





}
   
