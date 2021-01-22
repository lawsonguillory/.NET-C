using System;

namespace FirstProject
{
   class Program
   {
      static void Main(string[] args)
      {

         int ageInt;


         System.Console.WriteLine("What is your name?");

         string userName = Console.ReadLine();


         System.Console.WriteLine("Hello "+userName+"!");

         System.Console.WriteLine("What is your age?");

         string age = Console.ReadLine();

         ageInt=int.Parse(age);

         Console.WriteLine("In 15 years, your age will be "+(ageInt+15));


      }
   }
}

