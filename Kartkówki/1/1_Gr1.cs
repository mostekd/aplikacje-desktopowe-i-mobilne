using System;

class Program
{
    static void Main()
    {
        int[] array = { 64, 25, 12, 22, 11 };
        SelectionSort(array);
        Console.WriteLine("Sorted array:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
    }

    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }we
    }
}
