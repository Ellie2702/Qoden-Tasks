using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task1
{
    class Program
    {
        public class Array<T>
        {
            public T[] Items { get; set; }

        }


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

        class HashTable
        {
            public HashTable(int n)
            {
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
        
        static void Main(string[] args)
        {
            
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr = Console.ReadLine().Split(' ');
            int l = arr.Length;
            HashTable HT = new HashTable(n);
            for (int i = 0; i < l; i++)
            {
                try
                {

                    HT.insert(Convert.ToInt32(arr[i]));
                }
                catch { }
            }

            Console.WriteLine(n);
            Console.WriteLine(Environment.NewLine + Environment.NewLine);
            string s = n.ToString() + " " + Environment.NewLine;
            for (int i = 0; i < n; i++)
            {

                s += Environment.NewLine + i.ToString() + ": ";
                if (HT.values.Items[i] != null)
                {
                    ListNode<int> cur = HT.values.Items[i];
                    while (cur != null)
                    {
                        s += cur.value + " ";

                        cur = cur.next;
                    }
                }
               
            }


            Console.WriteLine(s);

            
        }
    }
}
