using System;

class BubbleSortExample
{
    static void Main()
    {
        // Utwórz tablicę 100-elementową i wypełnij ją losowymi wartościami
        int[] tab = new int[100];
        Random r = new Random();

        for (int i = 0; i < tab.Length; i++)
        {
            tab[i] = r.Next(0, 100); // Wartości od 0 do 99
        }

        Console.WriteLine("Tablica przed sortowaniem:");
        PrintArray(tab);

        // Wywołanie algorytmu sortowania bąbelkowego
        BubbleSort(tab);

        Console.WriteLine("\nTablica po sortowaniu:");
        PrintArray(tab);
    }

    // Funkcja implementująca sortowanie bąbelkowe
    static void BubbleSort(int[] array)
    {
        int n = array.Length;

        for (int j = 0; j < n - 1; j++)
        {
            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    // Zamiana miejscami
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }
        }
    }

    // Funkcja pomocnicza do wyświetlania zawartości tablicy
    static void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
