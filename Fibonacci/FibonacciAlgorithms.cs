namespace Fibonacci;
public sealed class FibonacciAlgorithms
{
    public static int FindTheNthFibonacciNumber(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        return FindTheNthFibonacciNumber(n - 1) + FindTheNthFibonacciNumber(n - 2);
    }

    public static List<int> CalculateFibonacciNumbersWithRecursion(int num1, int num2, List<int> fibonacciList)
    {
        var fibonacciNum = num1 + num2;

        if (fibonacciNum <= 100)
        {
            fibonacciList.Add(fibonacciNum);

            CalculateFibonacciNumbersWithRecursion(num2, fibonacciNum, fibonacciList);
        }

        return fibonacciList;
    }

    public static List<int> CalculateFibonacciNumbersWithLoop(int num1, int num2, List<int> fibonacciList)
    {
        for (int fibonacci = num1 + num2; fibonacci <= 100; fibonacci = num1 + num2)
        {
            num1 = num2;
            num2 = fibonacci;

            fibonacciList.Add(fibonacci);
        }

        return fibonacciList;
    }

}
