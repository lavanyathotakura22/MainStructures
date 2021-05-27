using System;
namespace Main_name
{			
	namespace Nest_name
	{	
		class Geeks_1
		{
			public Geeks_1() {
					
				Console.WriteLine("Nested Namespace Constructor");}}}}
class Driver
{
	public static void Main(string[] args)
	{
		new Main_name.Nest_name.Geeks_1();
		
	}	
}
