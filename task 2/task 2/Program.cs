using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_2
{
    class Program
    {
       
        public static void Main(string[] args)
        {
            string ss ="";
            StreamReader b = new StreamReader(@"D:\input");
            string s = b.ReadToEnd();
            b.Close();
            string k = "";
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                    continue;
                k += s[i];
            }
            int c = 0;
            for(int i = 0; i < k.Length; i++)
            {
                //to convert string to int 
                int t = int.Parse(string.Format("{0}", k[i]));
                for( int j = 1;  j <= t; j++)
                {
                    if (t % j == 0)
                        ++c;
                }
                if (c == 2)
                {
                    char t1 = Convert.ToChar(t);
                    ss = ss + t1;
                }
                c = 0;

            }
            Console.WriteLine(ss);
            writerforfile();
        }
        public static void writerforfile()
        {
           
        }
        
    }
}
