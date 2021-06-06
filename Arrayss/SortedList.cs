using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		SortedList<int,string> numberNames = new SortedList<int,string>(){ {3, "Three"},{1, "One"},{2, "Two"}};
    
		numberNames.Remove(1);                  //removes key 1 pair
		numberNames.Remove(10);                 //removes key 10. No error if key does not exists
	    numberNames.RemoveAt(0);                //removes key-value pair from index 0 
		//numberNames.RemoveAt(10);             //run-time exception: ArgumentOutOfRangeException
        //numberNames.Add(4, null);
        numberNames.Add(10, "Ten");
        numberNames.Add(5, "Five");
        numberNames[2] = "TWO"; //updates value
        numberNames[7] = "Four";
        foreach(var kvp in numberNames)
			Console.WriteLine("key: {0}, value: {1}", kvp.Key , kvp.Value );

   /*    for (int i = 0; i < numberNames.Count; i++){
            Console.WriteLine("key: {0}, value: {1}", numberNames.Keys[i], numberNames.Values[i]);} */
        
        
     /*   if(!numberNames.ContainsKey(4))//check if key exists
		{
			numberNames[4] = "Four";
		}
			
		string result;
			
		if(numberNames.TryGetValue(4, out result)) // try to get value of 4 key
			Console.WriteLine("Key: {0}, Value: {1}", 4, result);                     */
	}
}