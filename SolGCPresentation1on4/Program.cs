using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GCPresentation1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int j = 0; j < 10000; j++)
            {
                AllocateTables(2200, 20000);
            }
        }

        private static void AllocateTables(int size1, int size2)
        {
            DateTime old = DateTime.Now;

            object[] container = new object[size1];
            for (int j = 0; j < container.Length; j++)
            {
                container[j] = new object[size2];
            }
            Thread.Sleep(10);

            System.Console.WriteLine("Run with: (" + size1 + ", " + size2 + "), time=" + (DateTime.Now - old));
        }
    }
}
