using System;

namespace MainStructures {

   class NumberManipulator {
      public void MyMethod1(string s="lavanya"){
            Console.WriteLine(s);
      }
      public int factorial(int num) {
         int result;
         if (num == 1) {
            return 1;
         } else {
            result = factorial(num - 1) * num;
            return result;
         }
      }
      public int FindMax(int num1, int num2) {
         int result;
         
         if (num1 > num2)
            result = num1;
         else
            result = num2;
         return result;
      }
      
      static void Main(string[] args) {
         int a = 100;int b = 200;
         NumberManipulator n = new NumberManipulator();
         int ret = n.FindMax(a, b);
         n.MyMethod1();
         Console.WriteLine("Max value is : {0}", ret );
         Console.WriteLine("Factorial of 8 is : {0}", n.factorial(8));
         Console.ReadLine();
      }
   }
}