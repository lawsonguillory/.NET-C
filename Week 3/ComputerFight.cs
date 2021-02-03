using System;

namespace DiceRoller
{
	class Program
	{
		static void Main(string[] args)
		{
			Random numberGen = new Random();

			int rollOne = 0;
			int rollTwo = 1;
			int attempts = 0;
			string answer;
			string yes = "yes";

			Console.WriteLine("Are you ready to watch the computer fight?");
			answer = Console.ReadLine();
			string response = answer.ToLower();



			if (response==yes)
			{


				while (rollOne!=rollTwo)
				{
					rollOne=numberGen.Next(1,51);
					rollTwo=numberGen.Next(1,51);
					Console.WriteLine("Roll One: "+rollOne);
					Console.WriteLine("Roll Two: "+rollTwo);
					Console.WriteLine(" ");
					attempts++;

				}

				Console.WriteLine("It took the computer "+attempts+" attempts to be on the same page");
			}

			else
			{

				Console.WriteLine("Press Enter to Escape");
				Console.ReadKey();
			}

			
		}
	}
}
