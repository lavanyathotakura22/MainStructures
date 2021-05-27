using System;

public class GFG {
	
// Main method
public static void Main(string[] args) {

	DateTime dateToDisplay = new DateTime(2020, 5, 20, 18, 32, 0);
	System.Globalization.CultureInfo culture =
		new System.Globalization.CultureInfo("en-US");
	string output = String.Format(culture, "{0,-35:D}", dateToDisplay);
	Console.WriteLine(output);
}
}
