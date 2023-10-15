using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PaulikKV.Sprint2.Task4.V9.Lib;

namespace Tyuiu.PaulikKV.Sprint2.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = -1;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 1073741824;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 9999.7;
            Assert.AreEqual(wait, res);
        }
    }
}
