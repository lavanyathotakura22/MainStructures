using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ExtensionMethods
{
    public interface IMyInterface{              //Interface craetion
        void MethodB();
    }   
    class A : IMyInterface
    {
        public void MethodB() { Console.WriteLine("A.MethodB()"); }
    }

    class B : IMyInterface
    {
        public void MethodB() { Console.WriteLine("B.MethodB()"); }
        public void MethodA(int i) { Console.WriteLine("B.MethodA(int i)"); }
    }

    class C : IMyInterface
    {
        public void MethodB() { Console.WriteLine("C.MethodB()"); }
        public void MethodA(object obj)
        {
            Console.WriteLine("C.MethodA(object obj)");
        }
    }
    class ExtMethodDemo
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();
            a.MethodA(1);           // Extension.MethodA(IMyInterface, int)
                                    // a.MethodA("hello");     // Extension.MethodA(IMyInterface, string)
            a.MethodB();            // A.MethodB().
            b.MethodA(1);           // B.MethodA(int)
            b.MethodB();            // B.MethodB().
            b.MethodA("hello");     // Extension.MethodA(IMyInterface, string)
       
            c.MethodA(1);           // C.MethodA(object)
            c.MethodA("hello");     // C.MethodA(object)
            c.MethodB();            // C.MethodB()
        }
    }
}
