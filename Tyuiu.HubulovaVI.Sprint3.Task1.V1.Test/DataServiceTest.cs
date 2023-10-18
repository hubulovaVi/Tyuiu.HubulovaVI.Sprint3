using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.HubulovaVI.Sprint3.Task1.V1.Lib;

namespace Tyuiu.HubulovaVI.Sprint3.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 7;
            double res = ds.GetMultiplySeries(startValue, stopValue);
            Assert.AreEqual(5.311, res);
        }
    }
}