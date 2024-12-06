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
            double expected = 3.024; 
            double res = ds.Calculate(x);
            Assert.AreEqual(expected, res);
        }
    }
}

