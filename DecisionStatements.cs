using System;
public class MainStructures{
    public static void Main(String[] args)
    {
        System.Console.WriteLine("Enter a value :");
        var a=int.Parse(Console.ReadLine());

        if(a<0)
            System.Console.WriteLine("{0} is a negative number",a);
        else if(a%2==0)
            Console.WriteLine($"{a} is an even number");
        else
            System.Console.WriteLine($"{a} is a odd number");


        System.Console.WriteLine("Enter b value :");
        var b=int.Parse(Console.ReadLine());
        if(b%5==0)
            if(b%2==0)
                System.Console.WriteLine($"{b} is divisible by 5 and 2");
            else
                System.Console.WriteLine($"{b} is divisible by 5 only");
        
        Console.WriteLine("Enter a character :");
        string c=Console.ReadLine();
        switch (c.ToUpper())
        {
            case ("A"):
                Console.WriteLine("You entered A");
                break;
            case "B":
                Console.WriteLine("You entered B");
                break;
                
            default:
                Console.WriteLine("No match found");
                break;
        }

    }
}