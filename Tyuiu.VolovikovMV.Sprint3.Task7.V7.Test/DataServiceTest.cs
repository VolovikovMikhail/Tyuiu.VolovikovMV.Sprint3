using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolovikovMV.Sprint3.Task7.V7.Lib;

namespace Tyuiu.VolovikovMV.Sprint3.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5, stopValue = 5, len = stopValue - startValue + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 15.189;
            valueWaitArray[1] = 11.673;
            valueWaitArray[2] = 9;
            valueWaitArray[3] = 0;
            valueWaitArray[4] = 4.081;
            valueWaitArray[5] = 1.5;
            valueWaitArray[6] = -2.28;
            valueWaitArray[7] = -6.52;
            valueWaitArray[8] = -10.188;
            valueWaitArray[9] = -12.763;
            valueWaitArray[10] = -14.676;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
 
        }
    }
}
