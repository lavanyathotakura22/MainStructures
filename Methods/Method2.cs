using System;
namespace methodsss
{
    public class Person
    {
        public Person()
        {
            Name = "unknown";
        }
        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; }
        public override string ToString()
        {
            return Name;
        }
    }
    class TestPerson
    {
        static void Main()
        {
            var person1 = new Person();
            Console.WriteLine(person1.Name);
            var person2 = new Person("Sarah Jones");
            Console.WriteLine(person2.Name);
            Console.WriteLine(person2);
        }
    }
}
// Output:
// unknown
// Sarah Jones
// Sarah Jones