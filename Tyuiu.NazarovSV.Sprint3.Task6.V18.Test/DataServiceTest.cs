using Tyuiu.NazarovSV.Sprint3.Task6.V18.Lib;
namespace Tyuiu.NazarovSV.Sprint3.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 9;
            int stopValue = 18;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int next = 221;
            Assert.AreEqual(next, res);
        }
    }
}
