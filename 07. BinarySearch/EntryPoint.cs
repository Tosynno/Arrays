using System;

class EntryPoint
{
    static void Main()
    {
        Random rng = new Random();

        int[] array = new int[1000];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rng.Next(50, 150);
        }

        Array.Sort(array);

        int lookingFor = 100;
        int start = 0;
        int end = array.Length - 1;
        int midpoint = (end + start) / 2;

        bool foundIt = false;

        while (!foundIt)
        {
            if (array[midpoint] == lookingFor)
            {
                foundIt = true;
            }
            else if (array[midpoint] > lookingFor)
            {
                end = midpoint - 1;
            }
            else if (array[midpoint] < lookingFor)
            {
                start = midpoint + 1;
            }

            midpoint = (end + start) / 2;
            Console.WriteLine($"{start} {end} {midpoint}");
        }

        Console.WriteLine($"The number {lookingFor} was found at index {midpoint}.");
    }
}