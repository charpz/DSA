using Arrays;
using Xunit;

namespace UnitTests;

public sealed class ArrayAlgorithms_should
{
    private const int Min = 1;
    private const int Max = 1000;
    private readonly int[] SampleArray = [12, 43, 3, 123, 345, 234, Min, 678, 34, Max, 4, 3, 67, 8, 69];
    private readonly int[] SortedArray = [Min, 3, 3, 4, 8, 12, 34, 43, 67, 69, 123, 234, 345, 678, Max];

    [Fact]
    public void Find_lowest_value_in_array()
    {
        var result = ArrayAlgorithms.FindLowestValueInArray(SampleArray);

        Assert.Equal(Min, result);
    }

    [Fact]
    public void Find_highest_value_in_array()
    {
        var result = ArrayAlgorithms.FindHighestValueInArray(SampleArray);

        Assert.Equal(Max, result);
    }

    [Fact]
    public void Sort_the_array_using_BubbleSort()
    {
        ArrayAlgorithms.BubbleSort(SampleArray);

        Assert.Equal(SortedArray, SampleArray);
    }

    [Fact]
    public void Sort_the_array_using_SelectionSort()
    {
        ArrayAlgorithms.SelectionSort(SampleArray);

        Assert.Equal(SortedArray, SampleArray);
    }

    [Fact]
    public void Sort_the_array_using_InsertionSort()
    {
        ArrayAlgorithms.InsertionSort(SampleArray);

        Assert.Equal(SortedArray, SampleArray);
    }

    [Fact]
    public void Sort_the_array_using_QuickSort()
    {
        ArrayAlgorithms.QuickSort(SampleArray);

        Assert.Equal(SortedArray, SampleArray);
    }

    [Fact]
    public void Sort_the_array_using_CountingSort()
    {
        ArrayAlgorithms.CountingSort(SampleArray);

        Assert.Equal(SortedArray, SampleArray);
    }

    [Fact]
    public void Sort_the_array_using_MergeSort()
    {
        var sampleArray = SampleArray;

        ArrayAlgorithms.MergeSort(ref sampleArray);

        Assert.Equal(SortedArray, sampleArray);
    }

    [Fact]
    public void Search_array_using_LinearSearch()
    {
        var result = ArrayAlgorithms.LinearSearch(SampleArray, Max);

        Assert.NotNull(result);
        Assert.Equal(9, result);
    }
}
