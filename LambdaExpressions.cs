using System;  
using System.Collections.Generic;  
using System.Linq;
namespace Mainstructures{ 
class Dog  
{  
   public string Name { get; set; }  
   public int Age { get; set; }   
}    
class demo{  
   static void Main(string[] args)  
   {  
      List<Dog> dogs = new List<Dog>() {   
         new Dog { Name = "Rex", Age = 4 },  
         new Dog { Name = "Sean", Age = 0 },  
         new Dog { Name = "Stacy", Age = 3 }  
      };  
      var newDogsList = dogs.Select(x => new { Age = x.Age, FirstLetter = x.Name[0] }); 
      var sortedDogs = dogs.OrderByDescending(y => y.Age); 
      foreach (var item in sortedDogs)  
      {   
         Console.Write(item.Age+" " );  
      }   
      /*int[] numbers = { 2, 3, 4, 5 };
      var squaredNumbers = numbers.Select(x => x * x);
      Console.WriteLine(string.Join(" ",squaredNumbers));  */



      //Input parameters to lambda expressions
      
      /*Func<int, int> square = x => x * x;
        Console.WriteLine(square(5));*/


        //Tuples in Lambda Expressions

        /*Func<(int, int, int), (int, int, int)> doubleThem = ns => (2 * ns.Item1, 2 * ns.Item2, 2 * ns.Item3);
          var numbers = (2, 3, 4);
          var doubledNumbers = doubleThem(numbers);
          Console.WriteLine($"The set {numbers} doubled: {doubledNumbers}");*/
   }  
}  }
