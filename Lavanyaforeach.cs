using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Class2 
    {
        public static void Lavanyaforeach<T>(T l)
        {
            dynamic xvalue = l;
            /*IEnumarator<int> it = xvalue.GetEnumarator();
            while(it.MoveNext())
            {
                Console.WriteLine(it.Current.ToString());
            }*/

            public static void Main(String[] args)
            {
                List<int> C = new List<int>();
                C.Add(10);
                C.Add(6);
                C.Add(10);
                C.Add(6);
                C.Add(10);
                C.Add(6);
                Lavanyaforeach<List<int>>(C);
            }
        }
    }
}
