﻿using System;

namespace FirstProject
{
   class Program
   {
      static void Main(string[] args)
      {
  
         /// declares "ageInt" as int variable ///
         
         
         int ageInt;

         
         
         System.Console.WriteLine("What is your name?");

         string userName = Console.ReadLine();


         
         System.Console.WriteLine("Hello "+userName+"!");

         System.Console.WriteLine("What is your age?");

         string age = Console.ReadLine();
         
         
         /// Parses variable "age" into an integer to be added with variable "ageInt"
         
         
         ageInt=int.Parse(age);

         Console.WriteLine("In 15 years, your age will be "+(ageInt+15));


      }
   }
}

