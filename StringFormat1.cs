using System;

public class GFG	
{	
	// Main method
	public static void Main(string[] args)	
	{
		DateTime date1 = new DateTime(2020, 5, 20);
		TimeSpan hiTime = new TimeSpan(14, 17, 32);
		decimal hiTemp = 24.1m;
		TimeSpan loTime = new TimeSpan(3, 16, 10);
		decimal loTemp = 21.8m;
		
		// Converts the object to string
		string result1 = String.Format("Temperature on {0:d}:\n{1,11}: {2} degrees"+
									" (hi)\n{3,11}: {4} degrees (lo)", date1,
													hiTime, hiTemp, loTime, loTemp);
		Console.WriteLine(result1);
	}	
}
