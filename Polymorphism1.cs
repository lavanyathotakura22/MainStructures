using System;
namespace PolymorphismApplication {
    class Printdata 
    {
   
      public void print() {
         Console.WriteLine("Printing ");
      }

      public void print(float f) {
         Console.WriteLine("Printing float: {0}" , f);
      }

      public void print(string s) {
         Console.WriteLine("Printing string: {0}", s);
      }
    }
    class Printdata1 : Printdata
    {
       public void print(int i){
          Console.WriteLine("Printing int: {0}",i);
       }
      static void Main(string[] args) 
      {
         Printdata1 p = new Printdata1();
         p.print();
         p.print(4);
         p.print(5);
         p.print(500.263);
         p.print("Hello C++");
      }
   }
}