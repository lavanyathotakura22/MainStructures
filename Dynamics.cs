using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public class Dynamics
    {
        public static void Main()
        {
            dynamic stud = new Student();
            dynamic value1 = "GeeksforGeeks";
            dynamic value2 = 123234;
            stud.DisplayStudentInfo(1);

            //stud.DisplayStudentInfo(1, "Bill"); 
            //stud.FakeMethod();

            Console.WriteLine("Get the actual type of value1: {0}", value1.GetType().ToString());
            Project.addstr("Gjdjkwd", "G");
            Project.addstr("Hello", 1232);
            Project.addstr(12, 30);
        }
    }

    public class Student
    {
        public void DisplayStudentInfo(int id)
        {
            Console.WriteLine("Dummy Student");
        }
    }
    public class Project { 
        public static void addstr(dynamic s1, dynamic s2)
        {
            Console.WriteLine(s1 + s2);
        }
    }
}
