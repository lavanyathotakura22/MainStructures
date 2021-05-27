using System;
namespace MainStructures{
public abstract class Abstraction
{
    public abstract int Add(int a,int b);
    public abstract int Sub(int a,int b);
    public int Mul(int a,int b)
    {
        return a*b;
    }
    public int Div(int a,int b)
    {
        return a/b;
    }
    
}
public class Demo : Abstraction
{
    public override int Add(int x,int y)
    {
        return x+y;
    }
    public override int Sub(int x,int y)
    {
        return x-y;
    }
    public static void Main()
    {
        Demo d = new Demo();
        //Abstraction a = new Abstraction();
        System.Console.WriteLine(d.Add(10,20)); 
        System.Console.WriteLine(d.Sub(20,10));
        System.Console.WriteLine(d.Mul(10,20));
        System.Console.WriteLine(d.Div(20,10));
    }
}
}
