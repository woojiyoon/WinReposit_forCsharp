using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class test
{
    static void Main()
    {

        List<int> LL = new List<int>();

        while(true)
        {
            Console.WriteLine();
            int n = Convert.ToInt32(Console.ReadLine());
            
            if (n == -999) break;
            else
            {
                if(LL.IndexOf(n) == -1)
                    LL.Add(n);
                //LL.Insert((int)LL.Count/2, n);
                else
                {
                    LL.RemoveAt((LL.IndexOf(n)));
                }
                foreach (int i in LL)
                    Console.Write(i+" ");

            }
            

        }
     }

}

