using Arrays;

//int[] sampleArray = [23, 245, 546, 123, 4, 342, 2];
//int[] sampleArray = [11, 9, 12, 7, 3];

const int Min = 1;
const int Max = 1000;
int[] SampleArray = [12, 43, 3, 123, 345, 234, 1, 678, 34, 1000, 4, 3, 67, 8, 69];

ArrayAlgorithms.SelectionSort(SampleArray);

Console.WriteLine("Index: " + SampleArray);

static int[] RandomIntegerArray(int size, int min, int max)
{
    var randNum = new Random();

    var array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = randNum.Next(min, max);
    }

    return array;
}