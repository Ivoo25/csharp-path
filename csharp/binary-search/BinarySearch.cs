using System;

public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        return bsearch(value, 0, input.Length - 1); //call the recursive function
        int bsearch(int value, int min, int max) //recursive function that will execute until the value is found or the array is empty
        {
            if (min > max)
                return -1;  //not found
            int index = (max + min) / 2;
            if (input[index] > value)
                return bsearch(value, min, index - 1);
            if (input[index] < value)
                return bsearch(value, index + 1, max);
            return index;
        }
    }
}