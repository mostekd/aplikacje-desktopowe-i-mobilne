using System;

class Program
{
    static int LinearSearch(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return i;
            }
        }
        return -1;
    }

    static void Main()
    {
        int[] arr = { 5, 3, 7, 1, 9, 8 };
        int target = 7;

        int result = LinearSearch(arr, target);
        Console.WriteLine(result != -1 ? $"Element znaleziony na pozycji {result}" : "Element nie znaleziony");
    }
}
