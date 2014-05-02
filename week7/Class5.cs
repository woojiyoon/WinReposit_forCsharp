using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MyTest
{
    static void Main()
    { 
        List<int> list = new List<int>(); // list의 선언 및 초기화
        
        for (int i = 0; i < 5; i++)
            list.Add(i);    // list의 가장 마지막 원소 뒤에 값 추가

        Console.WriteLine("(1)");
        foreach (int n in list) // list 전부 출력
            Console.Write("{0} ", n);
        Console.WriteLine();

        list.RemoveAt(2);  // 특정 인덱스에 있는 원소 제거

        Console.WriteLine("(2)");
        foreach(int n in list)
            Console.Write("{0} ", n);
        Console.WriteLine();

        list.Insert(2, 7);   // 인덱스 2에 값 7넣기 .Insert(인덱스, 입력값)

        Console.WriteLine("(3)");
        foreach (int n in list)
            Console.Write("{0} ", n);
        Console.WriteLine();

        list.Add(5); // list의 가장 마지막 원소 뒤에 값 추가
        list.Add(7); // list의 가장 마지막 원소 뒤에 값 추가

        Console.WriteLine("(4)");
        foreach (int n in list)
            Console.Write("{0} ", n);
        Console.WriteLine();

        int x = list.ElementAt(2);// 특정위치의 값을 반환
        Console.WriteLine("(5)");
        Console.Write("{0}", x);
        Console.WriteLine();

        int y = list.IndexOf(3); //  .IndexOf(n)의 원소값 n이 리스트에 있으면 값 n을 반환, 없으면 -1 반환
        Console.WriteLine("(6)");
        Console.Write("{0}", y);
        Console.WriteLine();

        list.Remove(7);  // 해당 값과 일치하는 원소 한 개만 제거 (동일값이 두 개 이상이어도 인덱스가 낮은 것 하나만 제거함)
        Console.WriteLine("(7)");
        foreach (int n in list)
            Console.Write("{0} ", n);
        Console.WriteLine();

        Console.WriteLine("(8)");
        Console.WriteLine(list.Count); // list의 갯수

    }
}

