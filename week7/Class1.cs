using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Class1
{
    static void Main()
    {

        List<int> LL = new List<int>();
        for(int i = 0; i < 10; i ++)
        {
            LL.Add(i);
            Console.WriteLine(LL[i]);
        }
        Console.WriteLine("====");
        int n = Convert.ToInt32(Console.ReadLine());

        LL.Insert((int)LL.Count/2, n);

        foreach (int i in LL)
            Console.WriteLine(i);
    }
}

