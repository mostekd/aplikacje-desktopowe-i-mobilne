using System;

class Program
{
    static void Main()
    {
        int[] tab = new int[100];
        Random r = new Random();
        for (int i = 0; i < tab.Length; i++)
        {
            tab[i] = r.Next(0, 100);
        }

        Console.WriteLine("Unsorted array:");
        PrintArray(tab);

        BubbleSort(tab);

        Console.WriteLine("\nSorted array:");
        PrintArray(tab);
    }

    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int j = 0; j < n - 1; j++)
        {
            for (int i = 0; i < n - 1 - j; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
