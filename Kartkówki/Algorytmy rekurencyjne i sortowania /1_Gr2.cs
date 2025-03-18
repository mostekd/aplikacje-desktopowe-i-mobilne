using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 12, 11, 13, 5, 6 };
        InsertionSort(array);
        Console.WriteLine("Sorted array:");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
    }

    static void InsertionSort(int[] array)
    {
        int n = array.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j = j - 1;
            }
            array[j + 1] = key;
        }
    }
}
