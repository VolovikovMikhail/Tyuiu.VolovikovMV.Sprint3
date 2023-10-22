﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VolovikovMV.Sprint3.Task1.V22.Lib
{
    public class DataService : ISprint3Task1V22
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            value = 1.5;
            while (startValue <= stopValue)
            {
                sumSeries += (Math.Pow(value, startValue) + (1 / 2)) * Math.Cos(startValue);
                startValue++;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
