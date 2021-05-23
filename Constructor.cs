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
        public static void main(String[] args)
        {
            Constructor c = new Constructor();
        }
    }
}
