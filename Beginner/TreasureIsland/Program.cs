Console.WriteLine("Welcome to Treasure Island!");
Console.WriteLine("Your mission is to find the treasure.");
string firstchoice;
string secondchoice = "";
string thirdchoice = "";
Console.WriteLine("You are at a crossroad. Do you go left or right? Type 'left' or 'right'.");
firstchoice = Console.ReadLine().ToLower();
if (firstchoice == "left")
{
    Console.WriteLine("You have come to a lake. There is an island in the middle of the lake. " +
        "Type 'wait' to wait for a boat or 'swim' to swim for it.");
    secondchoice = Console.ReadLine().ToLower();
} else
{
    Console.WriteLine("You fall into a sinkhole. Game over!");
}
if (secondchoice == "wait")
{
    Console.WriteLine("You arrive at the island unharmed. There is a house with 3 doors: one red," +
        "one yellow and one blue. Which colour door do you enter?");
        thirdchoice = Console.ReadLine().ToLower();
} else
{
    Console.WriteLine("You drowned. Game over!");
}
if (thirdchoice == "red")
{
    Console.WriteLine("This room is full of fire. Game over!");

} else if (thirdchoice == "yellow")
{
    Console.WriteLine("You found the treasure. You win!");
} else if (thirdchoice == "blue")
{
    Console.WriteLine("You enter a room full of piranhas. Game over!");
