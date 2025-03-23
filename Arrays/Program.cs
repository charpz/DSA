//int[] sampleArray = [23, 245, 546, 123, 4, 342, 2];

int[] sampleArray = [11, 9, 12, 7, 3];

Console.Write("QuickSorted array: ");
QuickSort(sampleArray, 0, sampleArray.Length - 1);
foreach (var item in sampleArray)
{
    Console.Write(item + " ");
}

static void QuickSort(int[] array, int lowIndex, int highIndex)
{
    if (lowIndex >= highIndex) return;

    var pivot = array[highIndex];
    var leftPointer = lowIndex;
    var rightPointer = highIndex;

    while (leftPointer < rightPointer)
    {
        while (array[leftPointer] <= pivot && leftPointer < rightPointer)
        {
            leftPointer++;
        }

        while (array[rightPointer] >= pivot && leftPointer < rightPointer)
        {
            rightPointer--;
        }

        (array[rightPointer], array[leftPointer]) = (array[leftPointer], array[rightPointer]);
    }

    (array[highIndex], array[leftPointer]) = (array[leftPointer], array[highIndex]);

    QuickSort(array, lowIndex, leftPointer - 1);
    QuickSort(array, leftPointer + 1, highIndex);
}
