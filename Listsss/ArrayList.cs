using System;
using System.Collections;
namespace MainStructures{
public class ArrayLists
{
    
    public static void Main()
    {
        ArrayList a = new ArrayList(); 
        a.Add(20);
        a.Add("lavanya");
        a.Add(2.5);
        a.Add(true);
        a.Add(null);

        System.Console.WriteLine("Initial Array List is :");
        foreach(var i in a)
        {
            System.Console.Write($"{i}, ");
        }
        System.Console.WriteLine();
        int firstElement = (int) a[0];
        Console.WriteLine(firstElement);
        
        a.Insert(4,"Hello");                    //insert method
        foreach(var i in a)
        {
            System.Console.Write($"{i}, ");
        }
        System.Console.WriteLine();

        ArrayList arlist1 = new ArrayList(){100, 200, 600 };
        a.InsertRange(4,arlist1);
        a.Remove(null);
        Console.WriteLine(arlist1.Contains(300));
        System.Console.WriteLine("After Insert Range the list is :");
        foreach(var i in a)
        {
            System.Console.Write($"{i}, ");
        }
        System.Console.WriteLine();

    }
}
}


