using System;
namespace MainStructures
{
    class Student
    {
        private string code = "N.A";
        private string name = "not";
        private int age = 20;
        public string Code
        {
            get { return code; }
            set {code = value;}
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get{return age; }
            set{
                if (value > age)
                    age = value;
            }
        }
        public override string ToString()
        {
            return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
        }
    }
    class Propertie2
    {
        public static void Main()
        {
            Student s = new Student();
            s.Code = "001";
            s.Name = "Zara";
            s.Age = 10;
            Console.WriteLine("Student Info: {0}", s);
            s.Age += 1;
            Console.WriteLine("Student Info: {0}", s);
            Console.ReadKey();
        }
    }
}
