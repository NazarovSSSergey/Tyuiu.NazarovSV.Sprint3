﻿using Tyuiu.NazarovSV.Sprint3.Task5.V28.Lib;
namespace Tyuiu.NazarovSV.Sprint3.Task5.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 12;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double next = -1032.182;
            Assert.AreEqual(res, next);
        }
    }
}
