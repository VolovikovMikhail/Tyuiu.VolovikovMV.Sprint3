using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolovikovMV.Sprint3.Task0.V29.Lib;

namespace Tyuiu.VolovikovMV.Sprint3.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 1; int startValue = 1; int stopValue = 10;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 5.403;
            Assert.AreEqual(wait, res);
        }
    }
}
