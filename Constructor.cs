using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainStructures
{
    class Constructorsss
    {
        int x;
        //int m;
        public Constructorsss()           //parameter less constructor
        {
            Console.WriteLine("explicit constructor");
        }
<<<<<<< HEAD
        public Constructor(int i)
        {
            Console.WriteLine("explicit constructor"+i);
        }
        public static void main(String[] args)
        {
            Constructor c = new Constructor();
            Constructor c1= new Constructor(10);
=======
        static Constructorsss()
        {
            Console.WriteLine("this is static method");
        }
        public Constructorsss(int i)
        {
            x = i;
            Console.WriteLine("explicit constructor" + i);   //parameterized constructor
        }
        public void display()                  //mention on method for reusing purpose
        {
            Console.WriteLine("value of declared x value is: " + x);
        }
        public static void Main(String[] args)
        {
            Constructorsss c = new Constructorsss();
            Constructorsss c1 = new Constructorsss(10);
            //Constructorsss c2 = new Constructorsss();
            c1.display();
            //c2.display();
>>>>>>> 4fea71db3d7a1b8a7d20047a9fdd010f64328e87
        }
    }
}
