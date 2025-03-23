int[] sampleArray = [23, 245, 546, 123, 4, 342, 2];

//int[] sampleArray = [11, 9, 12, 7, 3];

Console.Write("MergeSorted array: ");
MergeSort(sampleArray);
foreach (var item in sampleArray)
{
    Console.Write(item + " ");
}

static void MergeSort(int[] array)
{
    var arrayHalfSize = array.Length / 2;

    var partitionX = new int[arrayHalfSize];
    var partitionY = new int[array.Length - arrayHalfSize];


}
