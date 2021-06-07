//example by TutorialsTeacher
using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		IList<Student> list = new List<Student>() { 
                        new Student() { StudentID = 1, StudentName = "John", age = 18 } ,
                        new Student() { StudentID = 2, StudentName = "Steve",  age = 21 }};
        var Arrays = new[] {
            new { Id = 1, FirstName = "James", LastName = "Bond" },
            new { Id = 2, FirstName = "Steve", LastName = "Jobs" }};

        var Arra1 = from s in list select new { Id = s.StudentID, Name = s.StudentName };
		
		foreach(var stud in Arrays)
			Console.WriteLine(stud.Id + "-" + stud.FirstName);
        Console.WriteLine(Arra1.GetType().ToString());
	}	
}
public class Student	
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int age { get; set; }
}
