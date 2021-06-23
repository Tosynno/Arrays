using System;
using System.Collections.Generic;

class EntryPoint
{
    static void Main()
    {
        Random rng = new Random();

        int[] array = new int[rng.Next(50, 100)];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rng.Next(1, 10);
        }

        List<int> ourFirstList = new List<int>();

        for (int i = 0; i < array.Length; i++)
        {
            if ((array[i] >= 5) && (array[i] <= 10))
            {
                ourFirstList.Add(array[i]);
            }
        }

        Console.WriteLine(string.Join(", ", array));
        Console.WriteLine(new string('-', 40));
        Console.WriteLine(string.Join(", ", ourFirstList));
    }
}
