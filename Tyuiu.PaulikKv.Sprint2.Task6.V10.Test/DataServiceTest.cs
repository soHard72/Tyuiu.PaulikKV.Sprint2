using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PaulikKv.Sprint2.Task6.V10.Lib;

namespace Tyuiu.PaulikKv.Sprint2.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            int g, m, n;
            g = 2005;
            m = 12;
            n = 15;
            string res = ds.FindDateOfPreviousDay(g, m, n);
            string wait = "14.12.2005";
            Assert.AreEqual(wait, res);
        }
            
    }
}
