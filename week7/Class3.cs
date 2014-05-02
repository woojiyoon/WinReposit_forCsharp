using System;
using System.Collections.Generic;
using System.Linq;

public class Student 
{
    public static int total = 0;  // total num of student
    public string name;
    public int id;

    public Student(string n1, int n2)
    {
        total++;
        this.name = n1;
        this.id = n2;
    }
}

public class Randomize
{
    public static void Shuffle(List<Student> LL)
    {
     
        Random r = new Random();
        int x;

        for (int i = LL.Count; i >= 1; i--)
        {
            
            x = r.Next(1, i + 1) - 1; 
            swap(LL, x, i - 1);
        }
    }

    static void swap(List<Student> n, int pos1, int pos2)
    {
        Student v1 = n.ElementAt(pos1); // posotion of random x
        Student v2 = n.ElementAt(pos2); // posotion of end of element

        n.RemoveAt(pos1);
        n.Insert(pos1, v2);
        n.RemoveAt(pos2);
        n.Insert(pos2, v1);
    }
    
}

class MainApp
{
    static void Main()
    {
        List<Student> list_student = new List<Student>();
        string Sname;
        int Sid = 0;
        int Nch = 0;

        Console.WriteLine("학생이름을 입력하세요. (qqq: 종료)");

        while (true)
        {
     
            Sname = Console.ReadLine();
            if (Sname == "qqq") 
                break;
            list_student.Add(new Student(Sname, Sid++));
        }

        Console.Write("몇명 선택하시겠습니까?<1-{0}>", Student.total);
        Nch = Convert.ToInt32(Console.ReadLine());

        Randomize.Shuffle(list_student);

        for (int i = 0; i < Nch; i++)
        {
            Console.Write(list_student[i].name);
            if (i < Nch - 1) Console.Write(" ,");
        }

        Console.Write(" 님이 밥을 사세요.");
        
    }
}
