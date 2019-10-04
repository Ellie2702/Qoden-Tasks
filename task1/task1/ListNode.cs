using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task1
{
    class ListNode<T>
    {
        public ListNode(T value)
        {
            this.value = value;
        }

        public T value { get; set; }
        public ListNode<T> next { get; set; }
        public void insert(T newValue)
        {
            ListNode<T> c = this;
            while (true)
            {
                if (c.next == null)
                {
                    break;
                }
                else
                {
                    c = c.next;
                }
            }

            c.next = new ListNode<T>(newValue);
        }
    }
}
