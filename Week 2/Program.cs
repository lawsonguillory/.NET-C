using System;

namespace EmployeeInfo
{
	class Program
	{
		static void Main(string[] args)
		{
		// Declaration of Variables// 

			string empname;
			string birthdate;
			string extensionname;
			string email;

			Console.WriteLine("Please Enter Name");

			empname = Console.ReadLine();
			Console.WriteLine("Enter Birthdate");

			birthdate=Console.ReadLine();
			Console.WriteLine("Enter Extension");
	
			extensionname=Console.ReadLine();
			Console.WriteLine("Enter Email Address");

			email=Console.ReadLine();

			Console.WriteLine("Your Information is as Follows: ");

																	// Printing Given Employee Information // 

			Console.WriteLine(empname+ " " + birthdate + " " + extensionname + " " +email);




		}
	}
}
