internal class Program
{
    static bool PrimeChecker(int number)
    {
        bool prime_number = true;
        for (int prime = 2; prime < number; prime++) 
        {
            if (number % prime == 0)
            {
                prime_number = false;
            }
        
        }
        if (prime_number)
        {
            Console.WriteLine("It's a prime number.");
        } else
        {
            Console.WriteLine("It's not a prime number.");
        }
        return prime_number;
          
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Check this number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        PrimeChecker(n);
    }
}
