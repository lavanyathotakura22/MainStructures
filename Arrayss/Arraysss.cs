using System;
namespace MainStructures{
using System.Linq;
class Arraysss {
  static void Main() {
    int[] num={10,20,30,40,50};
    int[] num1=new int[4];
    num[0]=70;
    Array.Copy(num,num1,4);                     //copy method
    foreach(var a in num1){
        Console.Write($"{a}"+" ");
    }
    Console.WriteLine();
    Array.Sort(num);                                //sort method
    foreach(int m in num){                  
        Console.Write(m+" ");}
    Console.WriteLine();
    //Console.BackgroundColor = ConsoleColor.DarkMagenta;
    int ele=int.Parse(Console.ReadLine());
    var z=Array.BinarySearch(num,ele);      //Binary search method
    if(z<0){
            Console.WriteLine("Element not present in the array");
        }
    else{
            Console.WriteLine($"Element present at the index {z}");
        }
    
    string[] s=new string[5];               //fill method
    Array.Fill(s,"lavanay");
    foreach(var j in s)
    {
        Console.Write($"{j} ");
    }
    
    Console.WriteLine();
    Console.WriteLine(num[0]+" " +num.Length+" "+num.Max()+" "+num.Min()+" "+num.Sum());
    
    int[] intArray = new int[5];                                  //alloacting memory for 5 integers
    intArray[0] = 10;intArray[1] = 20;intArray[2] = 30;         //initilize the variables
    foreach(int i in intArray){
        Console.Write(i+" ");}
    Console.WriteLine();

    string[] weekDays = new string[] {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};   //as our wish if you no need pass
    foreach(string day in weekDays){                                              //the size of the array
            Console.Write(day + " ");}
    int[] values = new int[10];
    Random rnd =new Random();
    for(int i=0;i<10;i++){
        values[i]=rnd.Next(0,50);
    }
    foreach(var i in values)
    {
        Console.Write($"{i} ");
    }
    
    //Array.Empty(weekDays);                                //this method is not workout
    //System.Console.Write(Array.Exists(weekDays,"Tue"));   //this method is not workout
    
        
    
  }
}
}
