using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class test
{
    static void printList(List<int> n)
    {
        foreach (int i in n)
            Console.Write(i + " ");
        Console.WriteLine();
    }

    static void swap(List<int> n, int pos1, int pos2)
    {
        int v1 = n.ElementAt(pos1);
        int v2 = n.ElementAt(pos2);

        n.RemoveAt(pos1);
        n.Insert(pos1, v2);
        n.RemoveAt(pos2);
        n.Insert(pos2, v1);
    }

    static void Main()
    {
        
        List<int> LL = new List<int>();
        for (int i = 1; i <= 10; i++)
            LL.Add(i);

        swap(LL, 3, 6);

        printList(LL);
            //foreach (int i in LL)
         //   Console.Write(i + " ");

     //   Console.WriteLine("input");
       // int n1 = Convert.ToInt32(Console.ReadLine());
       // int n2 = Convert.ToInt32(Console.ReadLine());

       // Console.WriteLine("{0}", LL.IndexOf(n1));
       // Console.WriteLine("{0}", LL.IndexOf(n2));
        //LL.RemoveAt(LL.IndexOf(n1));
        //LL.RemoveAt(LL.IndexOf(n2));

//        LL[LL.IndexOf(n1)] = n2;
  //      LL[ LL.IndexOf(n2)] = n1;



       // foreach (int i in LL)
         //   Console.Write(i + " ");


    }

}
