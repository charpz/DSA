
Console.WriteLine("Fibonacci Numbers with Recursion:");
var fibonacciNumbers = CalculateFibonacciNumbersWithRecursion(1, 2, [0, 1, 2]);

foreach (var number in fibonacciNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("Fibonacci Numbers with Loop:");

fibonacciNumbers = CalculateFibonacciNumbersWithLoop(1, 2, [0, 1, 2]);

foreach (var number in fibonacciNumbers)
{
    Console.WriteLine(number);
}

var result = FindTheNthFibonacciNumber(10);

Console.WriteLine($"The 10th Fibonacci number is {result}");

Console.ReadKey();

static int FindTheNthFibonacciNumber(int n)
{
    if (n <= 1)
    {
        return n;
    }

    return FindTheNthFibonacciNumber(n - 1) + FindTheNthFibonacciNumber(n - 2);
}

static List<int> CalculateFibonacciNumbersWithRecursion(int num1, int num2, List<int> fibonacciList)
{
    var fibonnacciNum = num1 + num2;

    if (fibonnacciNum <= 100)
    {
        fibonacciList.Add(fibonnacciNum);

        CalculateFibonacciNumbersWithRecursion(num2, fibonnacciNum, fibonacciList);
    }

    return fibonacciList;
}

static List<int> CalculateFibonacciNumbersWithLoop(int num1, int num2, List<int> fibonacciList)
{
    for (int fibonacci = num1 + num2; fibonacci <= 100; fibonacci = num1 + num2)
    {
        num1 = num2;
        num2 = fibonacci;

        fibonacciList.Add(fibonacci);
    }

    return fibonacciList;
}
