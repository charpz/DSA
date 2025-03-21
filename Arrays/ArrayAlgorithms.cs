﻿namespace Arrays;

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

    internal static int[] BubbleSort(int[] array)
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

        return array;
    }

    internal static int[] SelectionSort(int[] array)
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

        return array;
    }

    internal static int[] InsertionSort(int[] array)
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

        return array;
    }

}
