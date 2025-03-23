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

    var leftSize = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= pivot)
        {
            leftSize++;
        }
    }

    var leftPartition = new int[leftSize];
    var rightPartition = new int[array.Length - leftSize];
    var counter = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= pivot)
        {
            leftPartition[counter] = array[i];
            counter++;
        }
    }

    counter = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > pivot)
        {
            rightPartition[counter] = array[i];
            counter++;
        }
    }

    var leftSorted = QuickSort(leftPartition);
    var rightSorted = QuickSort(rightPartition);

    var result = new int[array.Length];

    counter = 0;

    for (int i = 0; i < leftSorted.Length; i++)
    {
        result[counter] = leftSorted[i];
        counter++;
    }

    result[counter] = pivot;

    for (int i = 0; i < rightSorted.Length; i++)
    {
        result[counter] = leftSorted[i];
        counter++;
    }

    return QuickSort(result);
}
