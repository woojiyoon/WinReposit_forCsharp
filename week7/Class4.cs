using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class test
{
    static void printLottery(List<int> n)
    { 
        // code here
        Console.Write("Today's lotter number : {0} {1} {2} {3} {4} {5}", n[0], n[1], n[2], n[3], n[4], n[5]);
    }

    static void printList(List<int> n)
    {
        foreach (int i in n)
            Console.Write(i + " ");
        Console.WriteLine();
    }

    static void swap(List<int> n, int pos1, int pos2)
    {
        int v1 = n.ElementAt(pos1); // posotion of random x
        int v2 = n.ElementAt(pos2); // posotion of end of element

        n.RemoveAt(pos1);
        n.Insert(pos1, v2);
        n.RemoveAt(pos2);
        n.Insert(pos2, v1);
    }

    static void Main()
    {
        List<int> LL = new List<int>();
        int x;
        for (int i = 1; i <=45; i++)
            LL.Add(i);

      //  printList(LL);
  //      Random r = new Random();
    //    int x = r.Next(1, LL.Count - i);
      //  Console.WriteLine();
      //  Console.WriteLine(LL.Count);  

        Random r = new Random();
        //for(int i = 0; i < LL.Count; i++)
        for (int i = LL.Count; i >= 1; i--)
        {
            
            //x = r.Next(1, LL.Count - i);
            x = r.Next(1, i + 1) - 1; 
            //Console.WriteLine("{0} : {1}", x,LL.Count() - i);

            //swap(LL, x, LL.Count - i- 1);
            swap(LL, x, i - 1);
        }            
        //swap(LL, 1, 9);
        printList(LL);
        printLottery(LL);
    }
}