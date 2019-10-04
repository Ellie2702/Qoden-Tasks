using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task1
{
    class HashTable
    {
        public HashTable(int n){
            this.values = new Array<ListNode<int>>();
            this.values.Items = new ListNode<int>[n];
        }

        public Array<ListNode<int>> values { get; set; }
        public void insert(int newValue)
        {
            int hash = newValue % values.Items.Length;
            if (values.Items[hash] == null)
            {
                values.Items[hash] = new ListNode<int>(newValue);
            }
            else
            {
                values.Items[hash].insert(newValue);
            }
        }
    }
}
