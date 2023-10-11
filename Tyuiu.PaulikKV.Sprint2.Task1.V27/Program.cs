using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PaulikKV.Sprint2.Task1.V27.Lib;

namespace Tyuiu.PaulikKV.Sprint2.Task1.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 654;
            int b = 325;
            int c = 154;
            int d = 333;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("A - " + a);
            Console.WriteLine("B - " + b);
            Console.WriteLine("C - " + c);
            Console.WriteLine("D - " + d);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
