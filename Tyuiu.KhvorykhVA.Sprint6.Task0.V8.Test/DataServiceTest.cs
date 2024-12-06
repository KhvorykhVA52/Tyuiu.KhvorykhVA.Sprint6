using Tyuiu.KhvorykhVA.Sprint6.Task0.V8.Lib;

namespace Tyuiu.KhvorykhVA.Sprint6.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double expectedResult = 3.024; 
            Assert.AreEqual(expectedResult, res);
        }
    }
}

