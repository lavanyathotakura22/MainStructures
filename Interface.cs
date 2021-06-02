using System;
namespace MainStructures{
    public interface A{
        void method1();
    }
    interface B : A{
        void method2();
    }
    public class C : B
    {
        public void method1(){
            Console.WriteLine("method1 in class C");
        }
        public void method2(){
            Console.WriteLine("method2 in class C ");
        }
    }
    public class D: B
    {
       public void method1(){
            Console.WriteLine("method1 in class D");
        }
       public void method2(){
            Console.WriteLine("method2 in class D");}
        public void method4(){
            Console.WriteLine("method4 in class D");
        }
        
    }
    public class E : A
    {
      public void method1(){
         Console.WriteLine("method1 in class E");
      }
      /* public void method3(){
           Console.WriteLine("method3 in class E");
       }*/
    }
      public class Progress{
        static void Main()
        {
            C obj = new C();
            D obj1=new D();
            A obj2=new E();
            obj.method1();
            obj.method2();
            obj1.method1();
            obj1.method2();
            obj1.method4();
            obj2.method1();
            //obj2.method3();
        }
    }
}