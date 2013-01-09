using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GCPresentation2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Fill(100 * 1024);
                Fill(100 * 1024, true, 15 * 1024 * 1024);
            }
            Console.ReadLine();
        }

        static void Fill(int objectSize, bool allocateTemporaryBigObject = false, int bigObjectSize = 0)
        {
            int i = 0;
            try
            {
             List<byte[]> container = new List<byte[]>();

             for (; ; i++)
             {
                 //GC.Collect();
                 if (allocateTemporaryBigObject)
                 {
                     allocateBigObject(bigObjectSize++);
                 }
                 container.Add(new byte[objectSize]);
             }
            }
            catch (OutOfMemoryException)
            {
                LogParameters(objectSize, allocateTemporaryBigObject, i);
            }
        }




        private static void LogParameters(int objectSize, bool allocateTemporaryBigObject, int i)
        {
            if (allocateTemporaryBigObject)
            {
                Console.WriteLine("{2} Z dużymi blokami w tablicy udało się zaalokować {0} x {1}KB", i, objectSize / 1024, DateTime.Now);
            }
            else
            {
                Console.WriteLine("{2} Bez dużych bloków w tablicy udało się zaalokować {0} x {1}KB", i, objectSize / 1024, DateTime.Now);
            }
        }

        private static void allocateBigObject(int bigObjectSize)
        {
            try
            {
                byte[] temp = new byte[bigObjectSize];
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine("Tworzenie dużego obiektu nie powiodło się przy rozmiarze {0}MB", bigObjectSize/1024/1024);
                throw e;
            }
        }
    }
}
