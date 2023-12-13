using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class DefaultExample<T> where T : struct 
    {
        public T CreateInstance()
        {
            return default(T);
        }
    }   
}
