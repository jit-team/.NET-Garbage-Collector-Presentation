using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using LRUCache;
using System.Runtime;

namespace FastDataProcessor
{
    class Program
    {
        private static LRUCache<String, String> cache = new LRUCache<string, string>(100);

        static void Main(string[] args)
        {
            for (int i = 0; i < 30000; i++)
            {
                
                string randomString = RandomStringGenerator.RandomString(1000, 1000);
                DateTime begin = DateTime.Now;

                string hash = MD5Helper.CalculateMD5Hash(randomString);
                cache.Add(hash, randomString);

                long ms = (DateTime.Now - begin).Milliseconds;

                LogTimeOncePer100Runs(i, hash, ms);
                LogTimeIfMoreThen(10, ms);

            }
            Console.ReadLine();
        }

        private static void LogTimeIfMoreThen(long max, long ms)
        {
            if (ms > max)
            {
                Console.WriteLine("!ms={0}", ms);
            }
        }

        private static void LogTimeOncePer100Runs(int i, string hash, long ms)
        {
            if (i % 100 == 0)
            {
                Console.WriteLine("i={0}, string={1}, time={2}", i, hash, ms);
            }
        }
    }
}

//GCSettings.LatencyMode = GCLatencyMode.LowLatency;
//GCSettings.LatencyMode = GCLatencyMode.SustainedLowLatency;
            
