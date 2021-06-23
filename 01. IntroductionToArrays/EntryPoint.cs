using System;

class EntryPoint
{
    static void Main()
    {
        Random rng = new Random();

        double[] temperatures = new double[5];

        //temperatures[0] = 36.6;
        //temperatures[1] = 37.0;
        //temperatures[2] = 37.2;
        //temperatures[3] = 36.7;
        //temperatures[4] = 36.9;
        //double[] temperatures = { 36.6, 37.0, 37.2, 36.7, 36.9 };

        char[] alphabet = { 'a', 'b', 'c', 'd', 'x', 'y', 'z' };

        //double minRange = 35.0;
        //double maxRange = 40.0;

        for (int i = 0; i < temperatures.Length; i++)
        {
            //temperatures[i] = minRange + (maxRange - minRange) * rng.NextDouble();
            Console.Write($"Please input a number for index {i}: ");
            temperatures[i] = Convert.ToDouble(Console.ReadLine());
        }
    }
}