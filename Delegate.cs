using System;
namespace MainStructures
{
    public delegate void A(int a, int b);
    //public delegate string B(string name);
    public class Program
    {
        public static void Add(int x, int y){
            Console.WriteLine((x + y));
        }
        public static void  Sub(int a,int b){
            Console.WriteLine((a - b));
        }
        public static int mymethod(int s, int d, int f, int g)      //Function for integer returning
        {
            return s * d * f * g;
        }
        public static bool IsUpperCase(string str)//RULE : Predicate delegate takes one input parameter and boolean return type.
        {
            return str.Equals(str.ToUpper());
        } 
        
        
        /*public static string Name(string name)
        {
            return  name;
        }*/
        static void Main(string[] args)
        {
            Program obj = new Program();
            A a = new A(Add);            //A a = new A(obj.Add);       //A a =obj.Add;
            a(100, 50);                     // a.Invoke(100, 50);
            a+=Sub;
            a.Invoke(10,20);
            a-=Add;
            a.Invoke(1,2);

            
            /*B b = new B(Name);
            //string B = b("Pranaya");            // string B = b.Invoke("Pranaya");
            Console.WriteLine(B);*/

            Func<int, int, int, int, int> val = mymethod;
            Console.WriteLine(val(10, 100, 1000, 1)+" Function value");

            Predicate<string> isUpper = IsUpperCase;   
            bool result = isUpper("hello world!!");
            Console.WriteLine(result +"   predicate");

            Action<int,int> printActionDel = Add;
            printActionDel(10,20);

            //Annonyms method
            
            A a1=delegate(int m,int n)
            {
                Console.WriteLine(m*n+ "     annonymous value");
            };a1(7,6);
        }
    }
}