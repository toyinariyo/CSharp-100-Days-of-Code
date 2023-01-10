string rock = "Rock";
string paper = "Paper";
string scissors = "Scissors";
string[] rps_art = { rock, paper, scissors };
Console.WriteLine("What do you choose? Type 0 for rock, type 1 for paper or type 2 for scissors");
int player_choice = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(rps_art[player_choice]);
Random random = new Random();
int computer_choice = random.Next(0, 2);
Console.WriteLine("Computer chose: ");
Console.WriteLine(rps_art[computer_choice]);
if (player_choice >= 3 || computer_choice < 0)
{
    Console.WriteLine("Invalid choice. You lose");
} else if (player_choice == 0 && computer_choice == 2)
{
    Console.WriteLine("Rock beats scissors. You win!");
} else if (computer_choice > player_choice)
{
    Console.WriteLine("You lose!");
} else if (computer_choice < player_choice)
{
    Console.WriteLine("You win!");
} else if (computer_choice == player_choice)
{
    Console.WriteLine("It's a draw");
}
