Dictionary<string, int> bids = new Dictionary<string, int>(); // Create an empty dictionary for the bids
bool bidding_finished = false; // Create a boolean for when the bidding has finished

void find_highest_bidder(Dictionary<string, int> bidding_record) // Argument for the bids empty dictionary
{
    int highest_bid = 0;
    string winner = "";
    foreach (var bidder in bidding_record)
    {
        int bid_amount = bidder.Value;
        if (bid_amount > highest_bid)
        {
            highest_bid = bid_amount;
            winner = bidder.Key;
        }
    }
    Console.WriteLine("Going once! Going twice! Sold to {0} with a bid of £{1}", winner, highest_bid);
}

while (!bidding_finished)
{
    Console.WriteLine("What is your name?");
    string name = Console.ReadLine();
    Console.WriteLine("How much are you bidding? £");
    int price = int.Parse(Console.ReadLine());
    bids[name] = price;
    Console.WriteLine("Are there any other bidders? Type 'yes' or 'no'.");
    string continue_bidding = Console.ReadLine();
    if (continue_bidding == "no")
    {
        bidding_finished = true;
        find_highest_bidder(bids);
    }
    else if (continue_bidding == "yes")
    {
        Console.WriteLine("\n" + 20);
    }
}
