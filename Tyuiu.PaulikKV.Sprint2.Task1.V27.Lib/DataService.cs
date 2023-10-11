using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PaulikKV.Sprint2.Task1.V27.Lib
{
    public class DataService : ISprint2Task1V27
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a == b + 328) | (c * 3 > d * 2);
            res[1] = (a != b) & (c == d);
            res[2] = (a > c) || (b < d);
            res[3] = (b + 7 <= d) && (a == c);
            res[4] = !(c < d / 3);
            res[5] = (a / 2 >= b + 2) ^ (c != d);
            return res;
        }
    }
}
