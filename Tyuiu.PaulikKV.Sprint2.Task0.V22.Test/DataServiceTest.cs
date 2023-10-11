﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PaulikKV.Sprint2.Task0.V22.Lib;

namespace Tyuiu.PaulikKV.Sprint2.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 3105;
            int y = 77;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, true, true, true, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
