using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAdvance
{
    public static class RandomNumberGenerator
    {
        private static Random random = new Random(DateTime.Now.Millisecond);
        public static int Generator()
        {
            return random.Next(10, 100);
        }
    }
}
