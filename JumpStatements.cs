using System;
namespace MainStructures
{
    public class JumpStatements
    {
        public static void Main(string[] args)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;
                Console.Write(i + " ");
            }

            Console.WriteLine();

            i = 0;
            while (i < 10)
            {
                if (i == 5)
                {
                    i++;
                    continue;
                }
                Console.Write(i + " ");
                i++;
            }

            Console.WriteLine();
            var c = Console.ReadLine();
            switch (c.ToUpper())
            {
                case ("A"):
                    Console.WriteLine("A");
                    break;
                case "B":
                    Console.WriteLine(" B");
                    goto case "A";

                default:
                    Console.WriteLine("No modifications");
                    break;
            }

            int a = 10, b = 20;
            Console.WriteLine($"sum of {a} and {b} is {add(a, b)}");

        }
        public static int add(int x, int y)
        {
            return (x + y);
        }
    }
}
