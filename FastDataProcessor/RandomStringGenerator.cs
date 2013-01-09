using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FastDataProcessor
{
    class RandomStringGenerator
    {
        private static Random random = new Random((int)DateTime.Now.Ticks);

        public static string RandomString(int size, int times)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            StringBuilder b = new StringBuilder(builder.Capacity * times);
            for (int i = 0; i < times; i++)
            {
                b.Append(builder);
            }
            return b.ToString();
        }
    }
}
