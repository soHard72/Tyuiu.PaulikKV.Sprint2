using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PaulikKV.Sprint2.Task0.V22.Lib;

namespace Tyuiu.PaulikKV.Sprint2.Task0.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 3105;
            int y = 77;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("X - " + x);
            Console.WriteLine("Y - " + y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат :                                                             *");
            Console.WriteLine("***************************************************************************");
            for(int i=0;i<6;i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();

        }
    }
}
