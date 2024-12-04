using System;

class LinearSearch
{
    public static int Search(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return i; // Zwraca indeks, gdy znajdzie element
            }
        }
        return -1; // Zwraca -1, jeśli elementu nie znaleziono
    }

    static void Main()
    {
        int[] array = { 1, 3, 5, 7, 9 };
        int target = 5;
        int result = Search(array, target);

        Console.WriteLine(result == -1 ? "Not found" : $"Found at index {result}");
    }
}
