using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Początkowy zestaw liczbowy:");
        PrintArray(numbers);

        SelectionSort(numbers);

        Console.WriteLine("\nPosortowany zestaw liczbowy w kolejności rosnącej:");
        PrintArray(numbers);
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

            Console.WriteLine($"\nKrok {i + 1}:");
            PrintArray(arr);
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
