using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task1
{
    class Program
    {
        
        
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

            Console.ReadLine();
        }
    }
}
