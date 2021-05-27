using System;
namespace MainStructures{
class AA
{
    public virtual void AMethod()
    {
    Console.WriteLine("This is A class");
    }
}

class BB:AA
{
    public override void AMethod()
    {
        Console.WriteLine("This is B class");
    }
    public virtual void Display()
    {
        Console.WriteLine("overided display method");
    }
}

class CC:BB
{
    public override void AMethod()
    {
    Console.WriteLine("This is C class");
    }
    public sealed override void Display()
    {
        Console.WriteLine("overriding selaed display method");
    }
}

class Test
{
    static void Main(string[] args)
    {
        BB b=new BB();
        CC c=new CC();
        AA d=new BB();
        BB e=new CC();
        c.Display();
        b.AMethod();
        //c.AMethod();
        d.AMethod();
        e.AMethod();
    }
}}