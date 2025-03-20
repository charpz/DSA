int[] sampleArray = [23, 245, 546, 123, 342, 2];

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


static int[] QuickSort(int[] array)
{
    var pivot = 0;

    for (int i = pivot; i < array.Length - pivot; i++)
    {
        var leftVal = i;
        var rightVal = i + 1;

        if (leftVal > rightVal)
        {
            array[i] = rightVal;
            array[i + 1] = leftVal;
        }
    }
}
