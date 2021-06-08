using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    
    public delegate T sampledelegate<T>(T variable);
    class GenericsSample<T>
    {
        
        public T value(T variable)
		{
			return variable;
		}
        
    }
    class GenericDeleagte
    {
        static void Main(string[] args)
        {
            
            GenericsSample<int> obj = new GenericsSample<int>();
            sampledelegate<int> del = new sampledelegate<int>(obj.value);
            Console.WriteLine(del.Invoke(10));
        }
    }
}