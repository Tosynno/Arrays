using System;

class EntryPoint
{
    static void Main()
    {
        int[] array = { 5, 7, 4, 3, 6 };
        
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    SwapValues(ref array[j], ref array[j + 1]);
                }
            }

            Console.WriteLine(string.Join(", ", array));
        }

        Console.WriteLine(new string('-', 40));
        Console.WriteLine(string.Join(", ", array));
    }

    static void SwapValues(ref int valueOne, ref int valueTwo)
    {
        int temp = valueOne;
        valueOne = valueTwo;
        valueTwo = temp;
    }
}