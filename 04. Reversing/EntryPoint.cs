using System;

class EntryPoint
{
    static void Main()
    {
        string[] fruits = { "orange", "lemon", "strawberry", "cherry", "kiwi" };

        //Array.Reverse(fruits, 1, 3);

        Reversing(fruits);

        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }

    static void Reversing(string[] array)
    {
        string temp = string.Empty;

        for (int i = 0; i < array.Length; i++)
        {
            temp = array[i];
            array[i] = array[array.Length - i - 1];
            array[array.Length - i - 1] = temp;
        }
    }
}