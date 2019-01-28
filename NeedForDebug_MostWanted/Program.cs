using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualLine;

namespace NeedForDebug_MostWanted
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] test = new double[50, 2];
            for (int i = 0; i < 50; i++)
            {
                test[i, 0] = -5 + (i * 0.2);
                test[i, 1] = test[i, 0] * test[i, 0] + test[i, 0];
            }
            DebuggerSide.Test(test);
            Console.WriteLine("Hell User!");
            Console.Read();
        }
    }
}
