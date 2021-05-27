using System;
class Mainmethod
{
    int n;
    public void simpleMethod()                    //non retrun type non parametred
    {
        Console.WriteLine("non return type method");
    }
    public int Method1(int value)            //return type parameterd
    {
        return value;
        
    }
    public void Method2(string message)     //non retrun type parameterd
    {
       Console.WriteLine("non retrun type with parameterized :"+message);
    }
    public int Method3()                    //return and without parameterd
    {
        Console.WriteLine("this is return type with non parameterized  "+n);
        return n;
    }
    static void Method(out int answer, out string message, out string stillNull)
    {
        answer = 44;
        message = "I've been returned";
        stillNull = null;
    }
    
    public static void Main(String[] args)
    {
        Mainmethod m=new Mainmethod();
        m.simpleMethod();
        int value =m.Method1(42);
        Console.WriteLine("retrun type and parameterd :"+value);
        m.Method2("lavanya");
        m.n=10;
        m.Method3();
        
        int argNumber;
        string argMessage, argDefault;
        Method(out argNumber, out argMessage, out argDefault);
        Console.WriteLine(argNumber);
        Console.WriteLine(argMessage);
        Console.WriteLine(argDefault == null);

        
    }
}