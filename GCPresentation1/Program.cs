using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GCPresentation1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] parameters = {new int[] {2200, 20000}, new int[] {2000, 22000}};
            Random r = new Random();
            for (int j = 0; j < 20; j++)
            {
                int index = r.Next(2);
                AllocateTables(parameters[index][0], parameters[index][1]);
            }
            Console.Read();
        }

        private static void AllocateTables(int size1, int size2)
        {
            DateTime old = DateTime.Now;

            object[] container = new object[size1];
            for (int j = 0; j < container.Length; j++)
            {
                container[j] = new object[size2];
            }

            System.Console.WriteLine("Run with: (" + size1 + ", " + size2 + "), time=" + (DateTime.Now - old));
        }
    }
}
