using System;
namespace Mainstructures{
    public class MainClass{
        public static void Main(String[] args){
            int j = 10;
            object obj= j; // boxing is converting the value type to the refernce type from int to object  
            obj = 20;
            Console.WriteLine(obj);
            double d = (double)(int)obj;    //converting the object to the value type
            //double d = (double)o;         //run time exception  first convert the value type and then casting
            Console.WriteLine(d);
        }
    }
}