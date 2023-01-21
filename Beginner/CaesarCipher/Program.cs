string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

void caesar(string start_text, int shift_amount, string cipher_direction)
{
    string end_text = "";
    if (cipher_direction == "decode")
    {
        shift_amount *= 1;
    }
    for (int i = 0; i < start_text.Length; i++)
    {
        char letter = start_text[i];
        if (alphabet.Contains(letter.ToString()))
        {
            int position = Array.IndexOf(alphabet, letter.ToString());
            int new_position = (position + shift_amount) % 26;
            end_text += alphabet[new_position];
        }
        else
        {
            end_text += letter;
        }
    }
    Console.WriteLine("The {0}d text is {1}", cipher_direction, end_text);
}

bool should_end = false;
while (!should_end)
{
    Console.WriteLine("Type 'encode' to encrypt, type 'decode' to decrypt");
    string direction = Console.ReadLine().ToLower();
    Console.WriteLine("Type your message: ");
    string text = Console.ReadLine().ToLower();
    Console.WriteLine("Type the shift number:");
    int shift = Convert.ToInt32(Console.ReadLine());
    caesar(start_text: text, shift_amount: shift, cipher_direction: direction);
    Console.WriteLine("Type 'yes' if you want to go again otherwise type 'no'.");
    string restart = Console.ReadLine().ToLower();
    if (restart == "no")
    {
        should_end= true;
        Console.WriteLine("Goodbye");
    }
}
