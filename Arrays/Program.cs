using Arrays;

int[] sampleArray = [23, 245, 546, 123, 4, 342, 2];
//int[] sampleArray = [11, 9, 12, 7, 3];

Console.Write("MergeSorted array: ");
ArrayAlgorithms.MergeSort(ref sampleArray);
foreach (var item in sampleArray)
{
    Console.Write(item + " ");
}
