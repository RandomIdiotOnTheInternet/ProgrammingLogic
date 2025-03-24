using System;

   class Program
   {
   static void Main(string[] args) {
         // Step 1
         Console.WriteLine("Gregory Blazek");
         Console.WriteLine("IT-1050-0-Programming Logic");

         // Step 2
         /*
         Name: Gregory Blazek
         Title: IT-1050 - Lab 1
         */

         // Step 3
         int favoriteNumber = 3;
         string favoriteProgrammingLanguage = "Python";
         double programsWritten = 6.0;
         bool hasProgrammingExperience = true;
         Console.WriteLine("My favorite number is " + favoriteNumber);
         Console.WriteLine("My favorite programming language is " + favoriteProgrammingLanguage);
         Console.WriteLine("I've written " + programsWritten + " programs");
         Console.WriteLine(hasProgrammingExperience + ", I do have coding experience");

         // Step 4
         const string schoolName = "Tri-C";
         Console.WriteLine("I go to " + schoolName);
      }
   }