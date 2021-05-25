
using System;
namespace MainStructures
{
class Test
{
    public static void Main()
    {
        int i=1;
        do                  //do-while loop
        {
            Console.WriteLine("Do While Loop");
            i++;
        }while(i<4); 
        i=1;
        while(i<4)          //while
        {
            Console.WriteLine("While Loop {0}",i);
            i++;
        }   
        for(i=1;i<4;i++)     //for loop
        {
            Console.WriteLine("Hello world {0}",i);
        }   
/*       i=1;
        while (true)          //infinite while loop
        {
            Console.WriteLine("Infinite while loop {0}",i);
            if(i==20)
                break;
            i++;
        }   
        i=1;                //infinite for loop
        for(;;)
        {
            Console.WriteLine("Infinite for loop {0}",i);
            if(i==20)
                break;
            i++;
        }                                                      */ 
        int[] a=new int[]{1,2,3,4,5};
        foreach(var j in a)
        {
            System.Console.Write($"{j} ");
        }

    }
}}

>>>>>>> 8e732eb9fdc91d2fec879fca83818939707b6f16
