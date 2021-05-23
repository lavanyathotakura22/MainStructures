using System;
namespace MainStructures
{
    struct MyStruct2
    {
        int i;
        /* public MyStruct2()
         {

         }*/
        public MyStruct2(int i)
        {
            this.i = i;
        }

        public void Display()
        {
            Console.WriteLine("method in structure: " + i);
            //Console.WriteLine(m);
        }
        static void Main()
        {   
            MyStruct2 m1;
            m1.i = 100;
            MyStruct2 m2 = new MyStruct2();
            MyStruct2 m3 = new MyStruct2(30);
            m1.Display();
            m2.Display();
            m3.Display();
            //int a=44
            Console.ReadLine();
        }
    }
}
