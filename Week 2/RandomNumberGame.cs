using System;

namespace RND
{
	class Public
	{
		static void Main()
		{
			


			Random r = new Random();
			double randomNumber = r.Next(1, 1000);
			double randomNumber2 = r.Next(1,1000);

			double numEntered;
			string storedName; 

			Console.WriteLine("What is Your Name? ");
			storedName=Console.ReadLine();



			Console.WriteLine("Hello! ");
			Console.WriteLine("Please Enter a Number >> ");

			numEntered=Convert.ToDouble(Console.ReadLine());
			numEntered=numEntered*randomNumber;
			Console.WriteLine("Your Randomized Number is: "+numEntered);
			Console.WriteLine(" ");


			if (randomNumber>=randomNumber2)
			{
				Console.WriteLine("Congratulations, " + storedName + " You Win! " );
			}
			else
			{
				Console.WriteLine("Sorry, " + storedName + " You Lose! ");
			}
		}
	}
}









