using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Box<T>
    {
        private T data;
        public void Add(T data)
        {
            this.data = data;
        }
        public T Get()
        {
            return data;
        }

        
    }
}
