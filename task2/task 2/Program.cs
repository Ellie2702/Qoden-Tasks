using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_2
{
    class Program
    {
        public static void sizes(List<string> x, int max,List<string> a)
        {
            max = 0;
            int res = 0;
            for (int i = 0; i < x.Count; i++)
            {
                if (x.ElementAt(i).Length > max)
                {
                    max = x.ElementAt(i).Length;
                }
            }
            string test = "";
            for (int i = 0; i < x.Count; i++)
            {
                if (x.ElementAt(i).Length < max)
                {
                    res = max - x.ElementAt(i).Length;
                   
                    for (int j = 0; j < res; j++)
                    {
                        test += "_";
                    }
                    
                }
                a.Add(test);
               test = "";
            }
            
        }


        public static void sort(List<string> l, List<string> w, List<string> d)
        {
            string temp = "";
            for(int i = 1; i < d.Count; i++)
            {
                for (int j = 0; j < d.Count; j++)
                {
                    if (d.ElementAt(j).Length > d.ElementAt(i).Length)
                    {
                        temp = d.ElementAt(j);
                        d[j] = d.ElementAt(i);
                        d[i] = temp;

                        temp = l.ElementAt(j);
                        l[j] = l.ElementAt(i);
                        l[i] = temp;

                        temp = w.ElementAt(j);
                        w[j] = w.ElementAt(i);
                        w[i] = temp;
                    }
                }
            }
        }


        public static void dotes(List<int> x, List<string> res)
        {
            string d = "";
            for(int i = 0; i < x.Count; i++)
            {
                for (int j = 0; j < x.ElementAt(i); j++)
                {
                    d += ".";
                }
                res.Add(d);
                d = "";
            }
        }


        static void Main(string[] args)
        {
            var list = new List<string>();
            list = Console.ReadLine().Split(' ').ToList();
         
            string test = " ";

            var res = new List<string>();
            var counts = new List<int>();
            string word = "";

            int count = 0;

            var w = list.Distinct().ToList();

            int n = w.Count;
            for (int i = 0; i < n; i++)
            {
                word = w.ElementAt(i);
                for (int j = 0; j < list.Count; j++)
                {
                    if (word == list.ElementAt(j))
                    {
                        count++;
                    }
                }
                
                res.Add(word);
                counts.Add(count);
                test += word + " " + count.ToString() + Environment.NewLine;
                count = 0;
            }


            int max = 0;
            var doted = new List<string>();
            var result = new List<string>(); 

            sizes(w, max, result);
            dotes(counts, doted);
            sort(result, w, doted);

            for (int i = 0; i < w.Count; i++)
            {
                Console.WriteLine(result.ElementAt(i) + w.ElementAt(i) + " " + doted.ElementAt(i));
            }

            Console.ReadLine();
            
        }
    }
}
