using System;

namespace CountYourVowels
{
	class Program
	{
		static void Main()
		{
			string phrase;
			string[] vowels = { "A","E","I","O","U","a","e","i","o","u" };
			int x, y;
			int count = 0;
			Console.WriteLine("Enter any phrase >>> ");
			phrase=Console.ReadLine();
			for (x=0;x<phrase.Length;++x)
				for (y=0;y<vowels.Length;++y)
					if (string.Equals(phrase.Substring(x,1),vowels[y])) ++count;
			Console.WriteLine("There are exactly {0} vowels in your phrase",count);

		}								 
	}
}
