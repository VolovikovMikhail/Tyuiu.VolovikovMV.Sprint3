using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolovikovMV.Sprint3.Task1.V22.Lib;

namespace Tyuiu.VolovikovMV.Sprint3.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1, stopValue = 20;
            double value = 1.5;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 3550.301;
            Assert.AreEqual(wait, res);

        }
    }
}
