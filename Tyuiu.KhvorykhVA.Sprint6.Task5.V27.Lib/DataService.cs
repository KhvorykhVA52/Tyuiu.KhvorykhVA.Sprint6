using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhvorykhVA.Sprint6.Task5.V27.Lib
{
    public class DataService : ISprint6Task5V27
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] data = File.ReadAllLines(path);
            double[] values = new double[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                values[i] = Double.Parse(data[i], NumberStyles.Any, CultureInfo.InvariantCulture);
            }

            return values;
        }
    }
}
