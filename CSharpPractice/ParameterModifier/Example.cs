using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifier
{
    public class Example
    {
        public string Append(params string[] s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in s)
            {
                sb.Append(item);
            }
            return sb.ToString();
        }

        public void Test1(ref int x)
        {
            // modifie allow
            x = 5;
        }
        public void Test2(in int x)
        {
            // modifie not allow
        }
        public void Test3(out int x)
        {
            x = 4;
        }
    }
}
