using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolovikovMV.Sprint3.Task5.V24.Lib;

namespace Tyuiu.VolovikovMV.Sprint3.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2, startValue1 = 1, startValue2 = 1, stopValue1 = 3, stopValue2 = 12;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double wait = -12926.893;
            Assert.AreEqual(wait, res);
        }
    }
}
