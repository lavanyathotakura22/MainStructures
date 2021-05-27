using System;
class EncapDemo
{
    private String SName;
    private int SAge;
    public String Name
    {
        get
        {
            return Name;
        }
        set
        {
            SName=value;
        }
    }
    public int Age
    {
        get
        {
            return Age;
        }
        set
        {
            SAge=value;
        }
    }
    public void Display()
    {
        System.Console.WriteLine("{0,-15} {1,-10}","Student Name","Student Age");
        System.Console.WriteLine("{0,-15} {1,-10}",SName,SAge);
    }
}
public class Encapsulation
{
    public static void Main()
    {
        EncapDemo e=new EncapDemo();
        e.Name="Ram";
        e.Age=20;
        e.Display();

    }
}