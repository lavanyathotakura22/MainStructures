using System;
namespace MainStructures
 {
    class A 
    {
   
      public virtual void Parent() {                              //method overloading and is a virtual method for overriding
         Console.WriteLine("overriding parent method");
      }
      public void Parent(string s) {                        //method overloading in parent class
         Console.WriteLine("Printing string: {0}", s);
      }
    }
    class B : A
    {
       public void Parent(int i){                                      //method overloadfing in child class
          Console.WriteLine("Printing int: {0}",i);
       }
       public override sealed void Parent(){
           Console.WriteLine("overriding child method"); 
       }
         static void Main(string[] args) 
         {
            B b=new B();
            b.Parent();
            b.Parent(4);
            b.Parent("hii");
         }
   }
}