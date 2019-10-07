using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task3
{
    class Program
    {

        

        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(' ');

            List<string> stroke = new List<string>();

            for (int i = 0; i < st.Length; i++)
            {
                stroke.Add(st[i]);
            }
            
       
            int result = 0;
          

            for (int i = 0; i < stroke.Count; i++)
            {
                try{
                    int d = Int32.Parse(stroke[i]);
                } catch {

                    switch (stroke[i])
                    {
                        case "+":
                            result = Convert.ToInt32(stroke[i-2]) + Convert.ToInt32(stroke[i-1]);
                            break;

                        case "-":
                            result = Convert.ToInt32(stroke[i - 2]) - Convert.ToInt32(stroke[i - 1]);
                            break;

                        case "*":
                            result = Convert.ToInt32(stroke[i - 2]) * Convert.ToInt32(stroke[i - 1]);
                            break;

                        case "/":
                            result = Convert.ToInt32(stroke[i - 2]) / Convert.ToInt32(stroke[i - 1]);
                            break;
                    }

                    stroke[i] = result.ToString();

                    stroke.Remove(stroke[i - 2]);
                    stroke.Remove(stroke[i - 2]);

                    if (stroke.Count != 1)
                    {
                        i = 0;
                    }
                }
                
            }

            Console.Write(result.ToString());
            Console.ReadLine();

        }
    }
}
