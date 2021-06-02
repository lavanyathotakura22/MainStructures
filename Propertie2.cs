using System;
namespace MainStructures
{
    class Student
    {
        private string code = "N.A";
        private string name = "not";
        private int age = 9;
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
                if (value > age){
                    age = value;}
                else{
                    Console.WriteLine("age must be greater than 20");
                }
            }
        }
       /* public override string ToString()
        {
            return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
        }*/
    }
    class Propertie2
    {
        public static void Main()
        {
            Student s = new Student();
            s.Code = "001";
            s.Name = "Zara";
            s.Age = 10;
            Console.WriteLine("Student Info: Name: {0}   Age: {1}   Code: {2}", s.Name,s.Age,s.Code);
            s.Age += 1;
            //Console.WriteLine("Student Info: {0}", s.Code);
        }
    }
}
