using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PaulikKV.Sprint2.Task2.V10.Lib
{
    public class DataService : ISprint2Task2V10
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ((y > 2 && x > 1 && y <= 14 && x <= 13) && ((x > 2 && x < 6 && y > 2 && y < 5) ||
                    (x > 8 && x < 13 && y > 2 && y < 5) || (x > 2 && x < 13 && y > 4 && y < 8) || (x == 13 && y > 5 && y < 8)
                    || (x > 5 && x < 14 && y == 8) || (x == 4 && y > 7 && y < 15) || (y == 11 && (x == 3 || x == 5))
                    || (y == 14 && (x == 2 || x == 3 || x == 5 || x == 6)) || (y == 9 && x > 5 && x < 10)
                    || ((x == 8 || x == 9) && (y > 9 && y < 13))))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
