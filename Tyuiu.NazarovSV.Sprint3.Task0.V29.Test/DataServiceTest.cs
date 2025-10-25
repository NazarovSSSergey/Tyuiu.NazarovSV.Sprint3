using Tyuiu.NazarovSV.Sprint3.Task0.V29.Lib;
namespace Tyuiu.NazarovSV.Sprint3.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double t = 0.5;
            int k = 1;
            int s = 10;
            double res = ds.GetSumSeries(t, k, s);
            double next = 2.065;
            Assert.AreEqual(res, next);
        }
    }
}
