using Tyuiu.NazarovSV.Sprint3.Task3.V7.Lib;
namespace Tyuiu.NazarovSV.Sprint3.Task3.V7.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "gft hggt ntg";
            char replaceable = 'g';
            char replacement = '4';
            string res = ds.ReplaceCharOnNum(value, replaceable, replacement);
            string wait = "4ft h44t nt4";
            Assert.AreEqual(res, wait);
        }
    }
}
