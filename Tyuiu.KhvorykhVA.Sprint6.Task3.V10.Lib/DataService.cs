using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KhvorykhVA.Sprint6.Task3.V10.Lib
{
    public class DataService
    {
        public int Calculate(int[,] array)
        {
            int count = 0;
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            if (rows >= 5)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[4, j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
