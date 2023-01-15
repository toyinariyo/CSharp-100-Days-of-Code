foreach (int number in Enumerable.Range(1, 100)) {
    if ((number % 3 == 0) && (number % 5 == 0)) {
        Console.WriteLine("FizzBuzz");
    }
    else if (number % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (number % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(number);
    }
}
