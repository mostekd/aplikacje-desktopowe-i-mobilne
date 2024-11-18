using System;

class Program
{
    static int SentinelLinearSearch(int[] array, int target)
    {
        int last = array[array.Length - 1];
        array[array.Length - 1] = target;

        int i = 0;
        while (array[i] != target)
        {
            i++;
        }

        array[array.Length - 1] = last;

        if (i < array.Length - 1) 
        {
            return i;
        }
        return -1;
    }

    static void Main()
    {
        int[] arr = { 5, 3, 7, 1, 9, 8 };
        int target = 7;

        int result = SentinelLinearSearch(arr, target);
        Console.WriteLine(result != -1 ? $"Element znaleziony na pozycji {result}" : "Element nie znaleziony");
    }
}
