using System;

class EntryPoint
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        //int[] secondArray = (int[])array.Clone();
        int[] secondArray = new int[array.Length];

        Array.Copy(array, secondArray, 3);
        
        ArrayCopy(array, 9, out int[] thirdArray);

        array[2] = 10;
        
        Console.WriteLine(array[2]);
        Console.WriteLine(secondArray[2]);
        Console.WriteLine(thirdArray[2]);

    }

    static void ArrayCopy(int[] sourceArray, int length, out int[] clonedArray)
    {
        clonedArray = new int[sourceArray.Length];

        if (!(length > sourceArray.Length))
        {
            for (int i = 0; i < length; i++)
            {
                clonedArray[i] = sourceArray[i];
            }
        }
    }
}