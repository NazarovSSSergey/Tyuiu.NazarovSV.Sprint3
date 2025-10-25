using Tyuiu.NazarovSV.Sprint3.Task4.V12.Lib;
namespace Tyuiu.NazarovSV.Sprint3.Task4.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double next = 467.59;
            Assert.AreEqual(res, next);
        }
    }
}
