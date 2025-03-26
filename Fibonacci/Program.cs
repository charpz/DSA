using Fibonacci;

Console.WriteLine("Fibonacci Numbers with Recursion:");
var fibonacciNumbers = FibonacciAlgorithms.CalculateFibonacciNumbersWithRecursion(1, 2, [0, 1, 2]);

foreach (var number in fibonacciNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("Fibonacci Numbers with Loop:");

fibonacciNumbers = FibonacciAlgorithms.CalculateFibonacciNumbersWithLoop(1, 2, [0, 1, 2]);

foreach (var number in fibonacciNumbers)
{
    Console.WriteLine(number);
}

var result = FibonacciAlgorithms.FindTheNthFibonacciNumber(10);

Console.WriteLine($"The 10th Fibonacci number is {result}");

Console.ReadKey();