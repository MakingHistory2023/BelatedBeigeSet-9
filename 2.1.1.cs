using System;

class Program 
{
   static void Main (string[] args) {

     // asking user to enter the inches to be converted
    Console.Write("Please enter the inches to be converted");

     //reading inches entered by the user
     double inches = double.Parse(Console.ReadLine());

     //converting inches to centimeters
     var centimeters = inches * 2.54;

     //printing result
     Console.WriteLine("{0} inches is {1} centimeters", inches, centimeters);
     
  }
}