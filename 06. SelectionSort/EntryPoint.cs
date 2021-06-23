using System;

class EntryPoint
{
    static void Main()
    {
        int[] array = { 5, 3, 100, 4, 1, -1 };

        int smallestIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            smallestIndex = i;

            for (int j = i; j < array.Length; j++)
            {
                if (array[smallestIndex] > array[j])
                {
                    smallestIndex = j;
                }
            }

            SwapValues(ref array[i], ref array[smallestIndex]);
            Console.WriteLine(string.Join(", ", array));
        }

        Console.WriteLine(string.Join(", ", array));
    }

    static void SwapValues(ref int valueOne, ref int valueTwo)
    {
        int temp = valueOne;
        valueOne = valueTwo;
        valueTwo = temp;
    }
}
