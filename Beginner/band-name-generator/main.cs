using System;

class Program {
  public static void Main (string[] args) {
    string city;
    string pet;
    Console.WriteLine ("Hello user. Welcome to Toyin's band name generator");
    Console.WriteLine("What city did you grow up in?");
    city = Console.ReadLine();
    Console.WriteLine("What is the name of your pet?");
    pet = Console.ReadLine();
    Console.WriteLine("Here is your band name: " + city + " " + pet);
  }
}
