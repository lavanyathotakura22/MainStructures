using System;
using System.Collections.Generic;
namespace MainStructures
{
public class Lists
{
    public static void Display<T>(List<T> list)
    {
        foreach(var i in list)
        {
            System.Console.Write($"{i}, ");
        }
        System.Console.WriteLine();
    }
    public static void Main()
    {
        List<int> primeNumbers=new List<int>();
        primeNumbers.Add(1); // adding elements using add() method
        primeNumbers.Add(3);
        primeNumbers.Add(5);
        primeNumbers.Add(7);
        primeNumbers[3]=13;
        System.Console.WriteLine("Prime Number List :");
        Display(primeNumbers);
        primeNumbers.Insert(4,11);                                  //inserts the elements to the list 
        System.Console.WriteLine("After Insert The List is :");
        Display(primeNumbers);

        primeNumbers.Remove(3);                                 //remove 3rd element
        primeNumbers.RemoveAt(1);                               //removes at 4th index
        System.Console.WriteLine("After Remove The List is :");
        Display(primeNumbers);
        System.Console.WriteLine();
                           
        Console.WriteLine(primeNumbers.Contains(10));           //contains method in lists

        var cities = new List<string>();
        cities.Add("New York");
        cities.Add("London");
        cities.Add("Mumbai");
        cities.Add("Chicago");
        cities.Add(null);                               // nulls are allowed for reference type list

        System.Console.WriteLine("Cities List :");
        Display(cities);

        string[] Pcities = new string[3]{ "Mumbai", "London", "New York" };
        cities.AddRange(Pcities);                           //add range is used to add elements from array to list
        System.Console.WriteLine("After AddRange The List is :");
        Display(cities);

    }
}
}

