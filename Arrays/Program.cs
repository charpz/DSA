//int[] sampleArray = [23, 245, 546, 123, 4, 342, 2];

int[] sampleArray = [11, 9, 12, 7, 3];

Console.Write("QuickSorted array: ");
var selectSorted = QuickSort(sampleArray);
foreach (var item in selectSorted)
{
    Console.Write(item + " ");
}

static int[] QuickSort(int[] array)
{
    if (array.Length <= 1) return array;

    var pivot = array[^1];


}
