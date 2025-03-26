namespace Arrays;
public static class ArrayUtils
{
    public static int[] RandomIntegerArray(int size, int min, int max)
    {
        var randNum = new Random();

        var array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = randNum.Next(min, max);
        }

        return array;
    }
}
