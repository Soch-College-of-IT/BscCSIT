﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment1.MultipleInheritance;

namespace Assignment1
{

	class Employee
	{
		// a.	Field Members: firstName, lastName, salary
		private string _firstName;
		private string _lastName;
		private double _salary;
		// b.	Properties : FirstName, LastName, FullName, Salary
		public string FirstName
		{
			get => _firstName;
			set
			{
				_firstName = value;
			}
		}

		public string LastName
		{
			get => _lastName;
			set
			{
				_lastName = value;
			}
		}

		public double Salary
		{
			get => _salary;
			set
			{
				_salary = value;
			}
		}

		// c.	Parameterized Constructor
		public Employee(string firstName, string lastName, double salary)
		{
			_salary = salary;
			_lastName = lastName;
			_firstName = firstName;
		}

		public void ShowFullName()
		{
			Console.WriteLine("Full Name is {0} {1}", _firstName, _lastName);
		}

		public void IncrementSalary(double s)
		{
			_salary += s;
		}
	}

	class Program
    {
		//static public int Add(int a, int b, int c) => a + b + c;

		//static public int Add(int a, int b ) => a + b;

		//static void Main(string[] args)
		//      {
		//	// i.	Constructor
		//	Employee e1 = new Employee("Bijaya", "Shrestha", 10000);
		//          // ii.	Display the Full Name and Salary using Properties
		//          //Console.WriteLine("Full Name is {0} {1}", e1.FirstName, e1.LastName);
		//          Console.WriteLine("Full Name is {0}",e1.FullName);
		//	Console.WriteLine("Salary is {0}", e1.Salary);
		//	// iii.	Change the First Name
		//	e1.FirstName = "Bijay";
		//	Console.WriteLine("First Name is changed as {0}", e1.FirstName);
		//	// iv.	Increment the Salary by 10%
		//	double incSal = 0.1 * e1.Salary;
		//	e1.IncrementSalary(incSal);
		//	Console.WriteLine("After increment by 10% salary is {0}", e1.Salary);
		//	// v.	Display Full Name and Salary by calling method.
		//	e1.Display();
		//	//static/compile Time Polymorphism , Overloading as example
		//          Console.WriteLine($"Add 3 items {Add(5, 9, 3)}");
		//          Console.WriteLine($"Add 2 items {Add(5,7)}");
		//	//Dynamic Polymorphism
		//	//Animal a = new Dog();
		//	//a.eat();
		//	//Console.WriteLine($"Color is {a.color}");
		//	//Multiple Inheritance using interfaces
		//	C c = new C();
		//	c.f1();
		//	c.f2();
		//	Console.ReadLine();
		//}

		static void Main(string[] args)
		{
			Employee emp1 = new Employee("Ram", "Bahadur", 20000);
			emp1.ShowFullName();
			Console.WriteLine("Salary is {0}", emp1.Salary);
			emp1.FirstName = "Hari";
			emp1.IncrementSalary(5000);
			emp1.ShowFullName();
			Console.WriteLine("Salary is {0}", emp1.Salary);
			Console.ReadLine();
		}
	}
}
