using Arrays;
using Xunit;

namespace UnitTests;

public sealed class ArrayAlgorithms_should
{
    private const int Min = 1;
    private const int Max = 1000;
    private readonly int[] SampleArray = [12, 43, 3, 123, 345, 234, Min, 678, 34, Max, 4, 3, 67, 8, 69];

    [Fact]
    public void Find_lowest_value_in_array()
    {
        var result = ArrayAlgorithms.FindLowestValueInArray(SampleArray);

        Assert.Equal(Min, result);
    }
}
