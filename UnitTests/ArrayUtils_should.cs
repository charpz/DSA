using Arrays;
using Xunit;

namespace UnitTests;
public static class ArrayUtils_should
{
    private const int Size = 10;
    private const int Min = 1;
    private const int Max = 100;

    [Fact]
    public static void RandomIntegerArray_ShouldGenerateArrayOfCorrectSize()
    {
        var result = ArrayUtils.RandomIntegerArray(Size, Min, Max);

        Assert.Equal(Size, result.Length);
    }

    [Fact]
    public static void RandomIntegerArray_ShouldGenerateNumbersWithinRange()
    {
        var result = ArrayUtils.RandomIntegerArray(Size, Min, Max);

        Assert.All(result, num => Assert.InRange(num, Min, Max - 1));
    }
}
