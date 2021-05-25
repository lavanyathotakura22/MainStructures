using System;
namespace geeksforgeeks {
	
class Multidimensional {
	public static void Main()
	{
		int[, ] intarray = new int[, ] { { 1, 2 },
										{ 3, 4 },
										{ 5, 6 },
										{ 7, 8 } };
		int[, ] intarray_d = new int[4, 2] { { 1, 2 }, { 3, 4 },
											{ 5, 6 }, { 7, 8 } };
		string[, ] str = new string[4, 2] { { "one", "two" },
											{ "three", "four" },
											{ "five", "six" },
											{ "seven", "eight" } };
		int[,, ] intarray3D = new int[,, ] { { { 1, 2, 3 },
											{ 4, 5, 6 } },
											{ { 7, 8, 9 },
										{ 10, 11, 12 } } };
		int[,, ] intarray3Dd = new int[2, 2, 3] { { { 1, 2, 3 },
												{ 4, 5, 6 } },
												{ { 7, 8, 9 },
												{ 10, 11, 12 } } };
		Console.WriteLine("2DArray[0][0] : " + intarray[0, 0]);
        Console.WriteLine("2DArray[1][1] (other) : "+ intarray_d[1, 1]);
        Console.WriteLine("3DArray[1][0][1] : "+ intarray3D[1, 0, 1]);
        Console.WriteLine("3DArray[1][1][2] : "+ intarray3D[1, 1, 2]);
        Console.WriteLine("3DArray[0][1][1] (other): "+ intarray3Dd[0, 1, 1]);
		Console.WriteLine("3DArray[1][0][2] (other): "+ intarray3Dd[1, 0, 2]);
		Console.WriteLine("To String element");
		for (int i = 0; i < 4; i++)
			for (int j = 0; j < 2; j++)
				Console.Write(str[i, j] + " ");
	}
}
}
