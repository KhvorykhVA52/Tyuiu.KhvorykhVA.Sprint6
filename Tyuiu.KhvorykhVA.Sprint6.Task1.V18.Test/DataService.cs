using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhvorykhVA.Sprint6.Task1.V18.Lib;

namespace Tyuiu.KhvorykhVA.Sprint6.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction()
        {
            DataService ds = new DataService();
            double[] expectedValues = new double[] { -70.01, -59.9, -45.67, -27.33, -5.91, 20.66, 53.46, 93.55, 142.03, 200.01, 268.65 };
            double[] actualValues = ds.GetMassFunction(-5, 5);

            CollectionAssert.AreEqual(expectedValues, actualValues);
        }
    }
}
