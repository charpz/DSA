namespace Arrays;

internal sealed class ArrayAlgorithms
{
    internal static int FindLowestValueInArray(int[] array)
    {
        var minValue = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
            }
        }

        return minValue;
    }

    internal static int FindHighestValueInArray(int[] array)
    {
        var maxValue = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i];
            }
        }

        return maxValue;
    }

    internal static void BubbleSort(int[] array)
    {
        var swapped = false;

        for (int i = 0; i < array.Length - 1; i++)
        {
            var currentVal = array[i];
            var nextVal = array[i + 1];

            if (currentVal > nextVal)
            {
                array[i] = nextVal;
                array[i + 1] = currentVal;

                swapped = true;
            }
        }

        if (swapped)
        {
            BubbleSort(array);
        }
    }

    internal static void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            var minVal = array[i];
            var lowIndex = 0;

            // Get the minimal value
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < minVal)
                {
                    minVal = array[j];
                    lowIndex = j;
                }
            }

            // Move values to the right
            for (int k = lowIndex; k > i; k--)
            {
                array[k] = array[k - 1];
            }

            // Move lowest value to the front of the array
            array[i] = minVal;
        }
    }

    internal static void InsertionSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            var pivot = i;

            for (int j = 0; j < i; j++)
            {
                var rightVal = array[pivot];
                var leftVal = array[pivot - 1];

                if (rightVal < leftVal)
                {
                    array[pivot] = leftVal;
                    array[pivot - 1] = rightVal;
                    pivot--;
                }
            }
        }
    }

    internal static void QuickSort(int[] array, int lowIndex = 0, int? highIndex = null)
    {
        if (array.Length <= 1) return;

        highIndex ??= array.Length - 1;

        if (lowIndex >= highIndex) return;

        var pivot = array[highIndex.Value];
        var leftPointer = lowIndex;
        var rightPointer = highIndex;

        while (leftPointer < rightPointer)
        {
            while (array[leftPointer] <= pivot && leftPointer < rightPointer)
            {
                leftPointer++;
            }

            while (array[rightPointer.Value] >= pivot && leftPointer < rightPointer)
            {
                rightPointer--;
            }

            (array[rightPointer.Value], array[leftPointer]) = (array[leftPointer], array[rightPointer.Value]);
        }

        (array[highIndex.Value], array[leftPointer]) = (array[leftPointer], array[highIndex.Value]);

        QuickSort(array, lowIndex, leftPointer - 1);
        QuickSort(array, leftPointer + 1, highIndex);
    }

    internal static void CountingSort(int[] array)
    {
        var tempArray = new int[FindHighestValueInArray(array) + 1];

        for (int i = 0; i < array.Length; i++)
        {
            var @value = array[i];
            tempArray[value]++;
        }

        var arrayPos = 0;

        for (int i = 0; i < tempArray.Length; i++)
        {
            if (tempArray[i] == 0) continue;

            for (int j = 0; j < tempArray[i]; j++)
            {
                array[arrayPos] = i;
                arrayPos++;
            }
        }
    }

    [Obsolete("This method is not finished yet.", true)]
    internal static void RadixSort(int[] array)
    {
        // TODO: To be completed
    }

    internal static void MergeSort(ref int[] array)
    {
        if (array.Length <= 1)
        {
            return;
        }

        int mid = array.Length / 2;

        var left = array[..mid];
        var right = array[mid..];

        MergeSort(ref left);
        MergeSort(ref right);

        array = MergeWithTwoPointerTechnique(left, right);
    }

    internal static int[] MergeWithTwoPointerTechnique(int[] array1, int[] array2)
    {
        int[] result = new int[array1.Length + array2.Length];
        int i = 0, j = 0, k = 0;

        for (; i < array1.Length && j < array2.Length; k++)
        {
            result[k] = (array1[i] <= array2[j]) ? array1[i++] : array2[j++];
        }

        for (; i < array1.Length; k++, i++)
        {
            result[k] = array1[i];
        }

        for (; j < array2.Length; k++, j++)
        {
            result[k] = array2[j];
        }

        return result;
    }
}
