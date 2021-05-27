
using System;

public class GFG	
{	
	// Main method
	public static void Main(string[] args)	
	{
		DateTime date1 = new DateTime(2019, 11, 11);
		
		// Converts the object to string
		string s1 = string.Format("{0:D}", date1);
		Console.WriteLine(s1);
	}	
}
