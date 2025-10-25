﻿using Tyuiu.NazarovSV.Sprint3.Task2.V22.Lib;
namespace Tyuiu.NazarovSV.Sprint3.Task2.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 7;
            var res = ds.GetMultiplySeries(value, startValue, stopValue);
            double next = 0.125;
            Assert.AreEqual(next, res);
        }
    }
}
