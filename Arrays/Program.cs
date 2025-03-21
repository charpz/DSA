int[] sampleArray = [23, 245, 546, 123, 4, 342, 2];

//Console.WriteLine("Lowest value in the array: " + ArrayAlgorithms.FindLowestValueInArray(sampleArray));

//Console.Write("BublleSorted array: ");

//var sortedArray = ArrayAlgorithms.BubbleSort(sampleArray);
//foreach (var item in sortedArray)
//{
//    Console.Write(item + " ");
//}

//Console.Write("SelectionSorted array: ");
//var selectSorted = ArrayAlgorithms.SelectionSort(sampleArray);
//foreach (var item in selectSorted)
//{
//    Console.Write(item + " ");
//}

//Console.Write("InsertionSorted array: ");
//var selectSorted = ArrayAlgorithms.InsertionSort(sampleArray);
//foreach (var item in selectSorted)
//{
//    Console.Write(item + " ");
//}

Console.Write("QuickSorted array: ");
var selectSorted = QuickSort(ref sampleArray, 0);
foreach (var item in selectSorted)
{
    Console.Write(item + " ");
}

static int[] QuickSort(ref int[] array, int pivot)
{
    var pivotVal = array[pivot];
    var counter = 0;

    for (int i = pivot; i < array.Length - pivot; i++)
    {
        if (pivotVal > array[i])
        {
            var lowerVal = array[i];
            var pointer = i;

            for (int j = 1; j <= i - pivot; j++)
            {
                array[pointer] = array[i - j];
                pointer--;
            }

            array[pivot] = lowerVal;
            counter++;
        }
    }

    var newPivot = pivot + counter;

    if (counter > 0)
    {
        _ = QuickSort(ref array, 0);
        _ = QuickSort(ref array, newPivot + 1);
    }

    return array;
}