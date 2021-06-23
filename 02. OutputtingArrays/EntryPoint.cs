using System;
using System.Collections.Generic;

class EntryPoint
{
    static void Main()
    {
        //string[] beverages = { "coffe", "cola", "whisky", "milkshake", "water" };

        //Console.WriteLine("The available beverages are: ");
        //for (int i = 0; i < beverages.Length; i++)
        //{
        //    Console.WriteLine($"  {beverages[i]}");
        //}

        //Console.WriteLine(new string('-', 40));
        //Console.WriteLine("The available beverages are: ");
        //foreach (var beverage in beverages)
        //{
        //    Console.WriteLine($"  {beverage}");
        //}

        //string joinedArray = string.Join(", ", beverages);

        //Console.WriteLine(joinedArray);

        //Console.WriteLine(new string('-', 40));
        Random rng = new Random();

        int[] temperatures = new int[40];
        
        List<int> lowTemps = new List<int>();
        List<int> mediumTemps = new List<int>();
        List<int> highTemps = new List<int>();
        List<int> outOfRangeTemps = new List<int>();
        
        int lowTempCursorPosition = 2;
        int mediumTempCursorPosition = 2;
        int highTempCursorPosition = 2;
        int outOfRangeCursorPosition = 2;

        Console.Write("Range 1 to 10: " +
            "\n" +
            "\nRange 11 to 20: " +
            "\n" +
            "\nRange 21 to 30: " +
            "\n" +
            "\nOut of Range:" +
            "\n\n");

        for (int i = 0; i < temperatures.Length; i++)
        {
            temperatures[i] = rng.Next(0, 40);
        }

        for (int i = 0; i < temperatures.Length; i++)
        {
            if (temperatures[i] >= 1 && temperatures[i] <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(lowTempCursorPosition, 1);
                Console.Write($"{temperatures[i]} ");
                Console.ResetColor();

                lowTemps.Add(temperatures[i]);

                if (temperatures[i] == 10)
                {
                    lowTempCursorPosition += 3;
                }
                else
                {
                    lowTempCursorPosition += 2;
                }
            }
            else if(temperatures[i] >= 11 && temperatures[i] <= 20)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(mediumTempCursorPosition, 3);
                Console.Write($"{temperatures[i]} ");
                Console.ResetColor();

                mediumTemps.Add(temperatures[i]);
                mediumTempCursorPosition += 3;
            }
            else if(temperatures[i] >= 21 && temperatures[i] <= 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(highTempCursorPosition, 5);
                Console.Write($"{temperatures[i]} ");
                Console.ResetColor();

                highTemps.Add(temperatures[i]);
                highTempCursorPosition += 3;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(outOfRangeCursorPosition, 7);
                Console.Write($"{temperatures[i]} ");
                Console.ResetColor();

                outOfRangeTemps.Add(temperatures[i]);

                if (temperatures[i] == 0)
                {
                    outOfRangeCursorPosition += 2;
                }
                else
                {
                    outOfRangeCursorPosition += 3;
                }
            }
        }

        Console.SetCursorPosition(0, 8);
    }
}