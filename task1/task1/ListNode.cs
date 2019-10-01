using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task1
{
    interface ListNode<T>
    {
        T value { get; set; }
        ListNode<T> next { get; set; }
        public void insert(T newValue)
        {
            
        }
    }
}
