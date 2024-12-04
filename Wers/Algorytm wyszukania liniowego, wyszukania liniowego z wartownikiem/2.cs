using System;

class LinearSearchWithSentinel
{
    public static int Search(int[] array, int target)
    {
        int n = array.Length;
        int[] newArray = new int[n + 1];
        Array.Copy(array, newArray, n);
        newArray[n] = target; // Dodajemy wartownika

        int i = 0;
        while (newArray[i] != target)
        {
            i++;
        }

        return i == n ? -1 : i; // Sprawdzenie, czy znaleziony to wartownik
    }

    static void Main()
    {
        int[] array = { 1, 3, 5, 7, 9 };
        int target = 5;
        int result = Search(array, target);

        Console.WriteLine(result == -1 ? "Not found" : $"Found at index {result}");
    }
}
