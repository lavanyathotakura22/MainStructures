using System;

public class Operators
{
    public static void ArithmeticOp()
    {
        System.Console.WriteLine("Enter the values of \"a\" and \"b\" :");
        int a=int.Parse(Console.ReadLine());
        int b=int.Parse(Console.ReadLine());
        System.Console.WriteLine("\t Arithmetic Operators in C# ");
        System.Console.WriteLine($"\t\t {a} + {b} = {a+b}");
        System.Console.WriteLine($"\t\t {a} - {b} = {a-b}");
        System.Console.WriteLine($"\t\t {a} * {b} = {a*b}");
        System.Console.WriteLine($"\t\t {a} / {b} = {a/b}");
        System.Console.WriteLine($"\t\t {a} % {b} = {a%b}");
        System.Console.WriteLine($"\t\t {a}++ = {a++}");
        System.Console.WriteLine($"\t\t {a}-- = {a--}");
    }
    public static void RealationalOp()
    {
        System.Console.WriteLine("Enter the values of \"a\" and \"b\" :");
        int a=int.Parse(Console.ReadLine());
        int b=int.Parse(Console.ReadLine());
        System.Console.WriteLine("\t Relational Operators in C# ");
        System.Console.WriteLine($"\t\t {a} == {b} = {a==b}");
        System.Console.WriteLine($"\t\t {a} != {b} = {a!=b}");
        System.Console.WriteLine($"\t\t {a} > {b} = {a>b}");
        System.Console.WriteLine($"\t\t {a} < {b} = {a<b}");
        System.Console.WriteLine($"\t\t {a} >= {b} = {a>=b}");
        System.Console.WriteLine($"\t\t {a} <= {b} = {a<=b}");
    }
    public static void LogicalOp()
    {
        var a=true;
        var b=false;
        System.Console.WriteLine("\t Logical Operators in C# ");
        System.Console.WriteLine($"\t\t {a} && {b} = {a&&b}");
        System.Console.WriteLine($"\t\t {a} || {b} = {a||b}");
        System.Console.WriteLine($"\t\t !{a} = {!a}");
    }
    public static void BitwiseOp()
    {
        int a=1,b=0;
        System.Console.WriteLine("\t Bitwise Operators in C# ");
        System.Console.WriteLine($"\t\t {a} & {b} = {a&b}");
        System.Console.WriteLine($"\t\t {a} | {b} = {a|b}");
        System.Console.WriteLine($"\t\t {a} ^ {b} = {a^b}");
        System.Console.WriteLine($"\t\t ~{a} = {~a}");
        System.Console.WriteLine($"\t\t {a}<<2 = {a<<2}");
        System.Console.WriteLine($"\t\t {a}>>2 = {a>>2}");
    }
    public static void Main()
    {
        //ArithmeticOp();
        //RealationalOp();
        LogicalOp();
        BitwiseOp();
    }
}