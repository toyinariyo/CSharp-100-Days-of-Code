using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Here is Toyin's tip calculator!");
    Console.WriteLine("What was the total bill?");
    decimal bill = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Was the tip 10, 12 or 15?");
    int tip = int.Parse(Console.ReadLine());
    Console.WriteLine("How many people are splitting the bill?");
    int people_split = int.Parse(Console.ReadLine());
    int tip_percentage = tip / 100;
    decimal total_tip = bill * tip_percentage;
    decimal total_bill = bill + total_tip;
    decimal bill_per_person = total_bill / people_split;
    decimal final_amount = Math.Round(bill_per_person, 2);
    Console.WriteLine("Each person should pay: " + "$" + final_amount); //Prints out wrong answer: 14 instead of 15.4 for total bill of 70, tip of 10 and 5 people splitting bill
    }
}
