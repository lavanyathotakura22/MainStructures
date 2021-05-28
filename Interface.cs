using System;
namespace MainStructures{
    public interface A{
        void method1();
    }
    interface B : A{
        void method2();
    }
    class C : B{
        public void method1(){
            Console.WriteLine("method1 in class C");
        }
        public void method2(){
            Console.WriteLine("method2 in class C ");
        }
    }
    class D: B
    {
       public void method1(){
            Console.WriteLine("method1 in class D");
        }
       public void method2(){
            Console.WriteLine("method2 in class D");
        }
    }
    public class E : A{
      public void method1(){
         Console.WriteLine("method1 in class E");
      }
      }
      public class Progress{
        static void Main()
        {
            C obj = new C();
            D obj1=new D();
            A obj2=new E();
            obj2.method1();
            obj.method1();
            obj.method2();
            obj1.method1();
            obj1.method2();
        }
    }
}