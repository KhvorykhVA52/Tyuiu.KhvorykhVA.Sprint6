using System;
using Tyuiu.KhvorykhVA.Sprint6.Task5.V27.Lib;

namespace Tyuiu.KhvorykhVA.Sprint6.Task5.V27.Test
{
    public class DataServiceTest
    {
        public static void TestLoadFromDataFile()
        {
            DataService dataService = new DataService();
            string filePath = @"C:\Users\User\source\repos\Tyuiu.KhvorykhVA.Sprint6\Tyuiu.KhvorykhVA.Sprint6.Task5.V27\bin\Debug\net8.0-windows\InPutDataFileTask5V27.txt";

            try
            {
                double[] data = dataService.LoadFromDataFile(filePath);

                Console.WriteLine("Данные успешно загружены:");
                foreach (var value in data)
                {
                    Console.WriteLine(value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке данных: {ex.Message}");
            }
        }

        public static void Main(string[] args)
        {
            TestLoadFromDataFile();
        }
    }
}
