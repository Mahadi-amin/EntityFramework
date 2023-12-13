using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public static class RandomNumberGenerator
    {
        private static Random random = new Random(DateTime.Now.Millisecond);
        public static int Generate()
        {
            return random.Next(10, 100);
        }
    }
}
