using System;

// 1 2 3 4 3 2 1

class EntryPoint
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 6, 5, 4, 3, 3, 1 };

        bool isSymmetrical = true;

        for (int i = 0; i < array.Length / 2; i++)
        {
            if (array[i] != array[array.Length - i - 1])
            {
                isSymmetrical = false;
                break;
            }
        }

        Console.WriteLine($"Is the array symmetrical: {isSymmetrical}");
    }
}
