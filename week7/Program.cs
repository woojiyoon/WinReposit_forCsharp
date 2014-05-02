using System;

public class Human
{
    public static int no;
    public int id = 0;
    public string name;

    public void setID()
    {
        id =++no;
    }

}

public class Test
{
    public static void Main()
    {
        Human.no = 0;
        Human h1 =  new Human();
        Human h2 =  new Human();
        Human h3 =  new Human();
        h1.setID();
        h2.setID();
        h3.setID();
        //Console.WriteLine(h1.id); //1
        //Console.WriteLine(h2.id); //2
        //Console.WriteLine(h3.id); //3

        Random r = new Random();
        
        for(int i = 0; i < 6; i++)
        {
            int x = r.Next(1, 45);
            Console.WriteLine(x);
        }
    }
}