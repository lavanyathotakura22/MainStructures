using System;
namespace Mainstructures{
public abstract class Figure
{
    public double radius,width,height;
    public const float PI=3.14f;
    public abstract double GetArea();
}
public class Rectangle : Figure
{
    public Rectangle(double width,double height)
    {
        this.width=width;
        this.height=height;
    }
    public override double GetArea()
    {
        return width*height;
    }
}
public class Circle : Figure
{
    public Circle(double radius)
    {
        this.radius=radius;
    }
    public override double GetArea()
    {
        return PI*radius*radius;
    }
}
public class AbstractDemo
{
    public static void Main(String[] args)
    {
        Rectangle r = new Rectangle(10,20);
        Circle c = new Circle(10);
        System.Console.WriteLine(r.GetArea());
        System.Console.WriteLine(c.GetArea());
    }
}
}