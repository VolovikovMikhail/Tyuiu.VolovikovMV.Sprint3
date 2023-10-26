using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolovikovMV.Sprint3.Task4.V19.Lib;

namespace Tyuiu.VolovikovMV.Sprint3.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5, stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 0;
            Assert.AreEqual(wait, res);
        }
    }
}
