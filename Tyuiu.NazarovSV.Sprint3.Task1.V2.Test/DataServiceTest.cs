using Tyuiu.NazarovSV.Sprint3.Task1.V2.Lib;
namespace Tyuiu.NazarovSV.Sprint3.Task1.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 15;
            var res = ds.GetSumSeries(startValue, stopValue);
            var next = ;
            Assert.AreEqual(next, res);
        }
    }
}
