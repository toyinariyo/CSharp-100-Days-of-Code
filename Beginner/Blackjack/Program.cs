internal class Program
{
    private static void Main(string[] args)
    {
        PlayGame();
    }

    static void ClearScreen()
    {
        Console.Clear();
    }

    static int DealCard()
    {
        List<int> cards = new List<int> { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10 };
        Random random = new Random();
        int card = cards[random.Next(0, cards.Count)];
        return card;
    }

    static int CalculateScore(List<int> cards)
    {
        if (cards.Sum() == 21 && cards.Count == 2)
        {
            return 0;
        }
        if (cards.Contains(11) && cards.Sum() > 21)
        {
            cards.Remove(11);
            cards.Add(1);
        }
        return cards.Sum();
    }

    static string Compare(int playerScore, int computerScore)
    {
        if (playerScore > 21 && computerScore > 21) {
            return "You went over 21. You lose";
        }
        else if (playerScore == computerScore)
        {
            return "Draw";
        }
        else if (computerScore == 0)
        {
            return "Computer has Blackjack";
        }
        else if (playerScore == 0)
        {
            return "Congratulations! You got a Blackjack";
        }
        else if (playerScore > 21)
        {
            return "You went over 21. You lose";
        }
        else if (computerScore > 21)
        {
            return "Computer went over 21. You win!";
        }
        else if (playerScore > computerScore)
        {
            return "You win";
        }
        else
        {
            return "You lose.";
        }
    }

    static void PlayGame()
    {
        ClearScreen();
        List<int> playerCards = new List<int>();
        List<int> computerCards = new List<int>();
        bool gameOver = false;
        for (int i = 0; i < 2; i++)
        {
            playerCards.Add(DealCard());
            computerCards.Add(DealCard());
        }
        while (!gameOver)
        {
            int playerScore = CalculateScore(playerCards);
            int computerScore = CalculateScore(computerCards);
            Console.WriteLine("Your cards: " + String.Join(", ", playerCards) + ", your current score is: " + playerScore);
            Console.WriteLine("Computer's first card: " + computerCards[0]);
            if (playerScore == 0 || computerScore == 0 || playerScore > 21)
            {
                gameOver = true;
            }
            else
            {
                Console.WriteLine("Type 'y' to get another card or type 'n' to pass: ");
                string playerDealsAgain = Console.ReadLine();
                if (playerDealsAgain == "y")
                {
                    playerCards.Add (DealCard());
                } else
                {
                    gameOver = true;
                }
            }
            while (computerScore < 17)
            {
                computerCards.Add(DealCard());
                computerScore = CalculateScore(computerCards);
            }
            Console.WriteLine("Your final hand: " + string.Join(", ", playerCards) + ", your final score is: " + playerScore);
            Console.WriteLine("Computer's final hand: " + string.Join(", ", computerCards) + ", computer's score is: " + computerScore);
            Console.WriteLine(Compare(playerScore, computerScore));
        }
        while (gameOver)
        {
            Console.WriteLine("Do you want to play a game of Blackjack? Type 'y' for yes or 'n' for no? ");
            string response = Console.ReadLine();
            if (response == "n")
            {
                break;
            }
            Console.Clear();
            PlayGame();
        }

    } 
    
}

