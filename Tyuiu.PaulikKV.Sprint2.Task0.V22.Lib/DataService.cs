﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PaulikKV.Sprint2.Task0.V22.Lib
{
    public class DataService : ISprint2Task0V22
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x + 1 == y;
            res[1] = x != y;
            res[2] = x < y + 3500;
            res[3] = x > y;
            res[4] = x <= y * 50;
            res[5] = x <= y;
            return res;
        }
    }
}
