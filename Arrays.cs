using System;
using System.Collections.Generic;
using System.Linq;
namespace MainStructures
{

    public class Arrays
    {
        /*public static T[] Empty<T>(a)
        {
            int[] a = new int[a.Length];
            return a;
        }*/
        public static void Main()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };

            int[] b = new int[5];

            Array.Copy(a, b, 5);
            foreach (var i in b)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            /*int ele=int.Parse(Console.ReadLine());
            var z=Array.BinarySearch(a,ele);
            if(z<0)
            {
                Console.WriteLine("Element not present in the array");
            }
            else{
                Console.WriteLine($"Element present at the index {z}");
            }*/
            int[] values = new int[50];
            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                values[i] = rnd.Next(0, 50);
            }
            foreach (var i in values)
            {
                Console.Write($"{i} ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Min value is {values.Min()}");
            System.Console.WriteLine($"Max value is {values.Max()}");

            /*string[] names={"hello","hai"};
            System.Console.Write(Array.Exists(names,"hai")); */

            //Array.Empty(a);
            //Array.Fill(a, 1);
            foreach (var i in a)
            {
                Console.Write($"{i} ");
            }
        }
    }
}