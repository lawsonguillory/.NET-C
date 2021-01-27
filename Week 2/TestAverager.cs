using System;

namespace Test_Averager
{
	class InteractiveTestScores
	{
		static void Main()
		{
			int TESTS = 8;
			int test1, test2, test3, test4, test5, test6, test7, test8;
			double total,avg;
			double passing = 70;
			Console.WriteLine("Enter Test Score 1 >>");
			test1=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Test Score 2 >>");
			test2=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Test Score 3 >>");
			test3=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Test Score 4 >>");
			test4=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Test Score 5 >>");
			test5=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Test Score 6 >>");
			test6=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Test Score 7 >>");
			test7=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Test Score 8 >>");
			test8=Convert.ToInt32(Console.ReadLine());

			total=test1+test2+test3+test4+test5+test6+test7+test8;
			avg=total/TESTS;

			if (avg >= passing)

			{
				
				Console.WriteLine("Congratualtions, You Passed!");
			}

			else
			{
				Console.WriteLine("Unfortunately, You failed.");


			}

			Console.WriteLine("Your Class Avergae Was "+avg);
			




			
		}
	}
}
