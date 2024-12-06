using Tyuiu.KhvorykhVA.Sprint6.Task3.V10.Lib;
namespace Tyuiu.KhvorykhVA.Sprint6.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[,]
            {
                { -17, 6, -19, 6, -13 },
                { -19, 3, 12, -11, 19 },
                { -20, 11, 9, 19, -19 },
                { -20, 10, -9, 17, 9 },
                { -4, 9, -8, 13, -8 }
            };

            int res = ds.Calculate(array);
            int expected = 0;
            Assert.AreEqual(expected, res);
        }
    }
}