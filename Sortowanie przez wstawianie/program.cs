using System;

class Program
{
    static void Main()
    {
        int[] array = GenerateRandomArray(10, 1, 100);
        Console.WriteLine("Tablica przed sortowaniem:");
        PrintArray(array);
        
        InsertionSort(array);
        
        Console.WriteLine("Tablica po sortowaniu:");
        PrintArray(array);
    }
    
    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;
            
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }
    
    static int[] GenerateRandomArray(int size, int minValue, int maxValue)
    {
        Random rand = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = rand.Next(minValue, maxValue + 1);
        }
        return array;
    }
    
    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }
}
