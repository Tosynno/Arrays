using System;
using System.Collections.Generic;
using System.Linq;

class EntryPoint
{
    static void Main()
    {
        string[] vegetables = { "cucumber", "cabbage" };
        string[] fruits = { "cherry", "strawberry", "blueberry" };
        string[] meat = { "beef", "pork" };

        List<string> food = ConcatenateStringArrays(new List<string[]>() { vegetables, fruits, meat });
        List<string[]> foodV2 = new List<string[]>() { vegetables, fruits, meat };

        foreach (var stringArray in foodV2)
        {
            foreach (var individualFood in stringArray)
            {
                Console.WriteLine(individualFood);
            }
        }
    }

    static List<string> ConcatenateStringArrays(List<string[]> listOfStringArrays)
    {
        List<string> concatenatedList = new List<string>();

        foreach (var stringArray in listOfStringArrays)
        {
            concatenatedList.AddRange(stringArray);
        }

        return concatenatedList;
    }
}
