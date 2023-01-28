Console.Clear();
var operations = new Dictionary<string, Func<double, double, double>>
{
    {"+", (n1, n2) => n1 + n2 },
    {"-", (n1, n2) => n1 - n2 },
    { "*", (n1, n2) => n1 * n2 },
    { "/", (n1, n2) => n1 / n2 }
};

double firstNumber = GetNumber("What's the first number?");
double secondNumber = GetNumber("What's the second number?");

foreach (var sign in operations.Keys)
{
    Console.WriteLine(sign);
}

bool shouldContinue = true;
while (shouldContinue)
{
    string operationSign = GetInput("Pick an operation from the line above: ");
    var calculationFunction = operations[operationSign];
    double answer = calculationFunction(firstNumber, secondNumber);
    Console.WriteLine($"{firstNumber} {operationSign} {secondNumber} = {answer}");
    string yesOrNo = GetInput($"Type 'y' to continue calculating with {answer} or type 'n' to start a new calculation: ");
    if (yesOrNo.Trim().ToLower() == "y")
    {
        firstNumber = answer;
    } else
    {
        shouldContinue = false;
        Console.Clear();
    }

}

static double GetNumber(string prompt)
{
    Console.WriteLine(prompt);
    return double.Parse(Console.ReadLine());
}

static string GetInput(string prompt)
{
    Console.WriteLine(prompt);
    return Console.ReadLine();
}
