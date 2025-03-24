using Arrays;

int[] sampleArray = [23, 245, 546, 123, 4, 342, 2];
//int[] sampleArray = [11, 9, 12, 7, 3];

var index = ArrayAlgorithms.LinearSearch(sampleArray, 342);

Console.WriteLine("Index: " + index);

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