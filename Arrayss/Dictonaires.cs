using System;
using System.Collections.Generic;
class GFG {
	public static void Main()
	{
		Dictionary<string, string> myDict =new Dictionary<string, string>();
        myDict.Add("1", "C");
		myDict.Add("2", "C++");
		myDict.Add("3", "Java");
		myDict.Add("4", "Python");
		myDict.Add("5", "C#");
		myDict.Add("6", "HTML");
		Console.WriteLine("Total key/value pairs"+" in myDict are : " + myDict.Count);

		Dictionary<string, string>.KeyCollection keyColl =myDict.Keys;
		foreach(string s in keyColl)
            Console.Write("Key ="+s+" ");
        Console.WriteLine();
        
        Dictionary<string, string>.ValueCollection valueColl =  myDict.Values;

        foreach(string s in valueColl)
        {
            Console.Write("Value ="+s+" ");
        }
        /*myDict.Clear();
  
        Console.WriteLine("Total key/value pairs in "+
             "myDict after Clear() operation are : " + 
                                        myDict.Count);*/

	}
}
