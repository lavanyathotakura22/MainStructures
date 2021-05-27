using System;	
namespace MainStructures	{		
public class BaseClass
{
	public virtual void Display()                            //// Virtual Method
	{
		Console.WriteLine("Base Class Display() Method is Called");
	}
	public virtual void Print()                              // Virtual Method
	{
		Console.WriteLine("Base Class Print() Method is Called");
	}
}
public class ChildClass : BaseClass                            // Normal Derived Class
{ 
	public override void Display()                                 // Overriding base class virtual method
	{
		Console.WriteLine("Child Class Overridden Display() Method is Called");
	}	
	public override sealed void Print()                         	// Sealed Method
	{
		Console.WriteLine("Child Class Sealed Print() Method is Called");
	}
}

// Sealed Derived Class
public sealed class DerivedClass : ChildClass
{

	public DerivedClass()
	{
		Console.WriteLine("Sealed Derived class Constructor is Called");
	}
	// Sealed Method
	public sealed override void Display()
	{
		Console.WriteLine("Derived Class Sealed Display() Method is Called");
	}	
	// Print() method of ChildClass cannot be Overridden anymore because it is sealed	
	
	// Destructor of sealed class
	~DerivedClass()
	{
		Console.WriteLine("Sealed Derived class Destructor is Called");
	}
}
public class Program
{
	public static void Main()
	{
		Console.WriteLine("\n---------- Base Class --------\n");
		BaseClass _baseClass = new BaseClass();
		_baseClass.Display();
		_baseClass.Print();
		
		Console.WriteLine("\n---------- Child Class --------\n");
		ChildClass _childClass = new ChildClass();
		_childClass.Display();
		_childClass.Print();	
		
		Console.WriteLine("\n---------- Sealed Derived Class --------\n");
		DerivedClass _derivedClass = new DerivedClass();
		_derivedClass.Display();
		_derivedClass.Print();			
		
	}
}}
