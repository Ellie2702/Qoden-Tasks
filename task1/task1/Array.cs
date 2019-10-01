using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task1
{
    public interface Array<T> : Array<T>
    {
        public Array<T> values { get; set; }

    }
}
