using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhvorykhVA.Sprint6.Task5.V27.Lib
{
    public class DataService : ISprint6Task5V27
    {
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                var lines = new List<string>();
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }

                double[] numsArray = new double[lines.Count];
                for (int i = 0; i < lines.Count; i++)
                {
                    numsArray[i] = Double.Parse(lines[i].Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture);
                }

                return numsArray;
            }
        }
    }
}
