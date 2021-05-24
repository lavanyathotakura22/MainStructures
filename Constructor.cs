using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainStructures
{
    class Constructor
    {
        public Constructor()
        {
            Console.WriteLine("explicit constructor");
        }
        public Constructor(int i)
        {
            Console.WriteLine("explicit constructor"+i);
        }
        public static void main(String[] args)
        {
            Constructor c = new Constructor();
            Constructor c1= new Constructor(10);
        }
    }
}
