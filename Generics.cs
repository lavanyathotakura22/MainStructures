using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Generics<T>
    {
		public T value(T variable)
		{
			return variable;
		}
	}
    class Printer
    {
        public void Print<T>(T data)
        {
            Console.WriteLine(data);
        }
    }
	class Test
	{

		static void Main(string[] args)
		{

			Generics<string> name = new Generics<string>();
			string m = name.value("lavanya");
            
            Printer printer = new Printer();
            //printer.Print<int>(100);
            printer.Print("lavanya");             //type infer from the specified value
			Console.WriteLine(m);
		}
	}
}

