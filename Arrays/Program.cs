//int[] sampleArray = [23, 245, 546, 123, 4, 342, 2];

using Arrays;

int[] sampleArray = [11, 9, 12, 7, 3];

Console.Write("MergeSorted array: ");
var result = ArrayAlgorithms.MergeSort(sampleArray);
foreach (var item in result)
{
    Console.Write(item + " ");
}
