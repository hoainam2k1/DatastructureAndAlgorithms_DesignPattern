using System;

public class SampleSelectionSort
{
    static void Main()
    {
        int[] data = new int[10];
        int minIndex = 0;
        int temp = 0;
        Random rand = new Random();
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = rand.Next(20, 90);
        }

        foreach (int i in data)
        {
            Console.WriteLine(i + " ");
        }
        Console.WriteLine("\n\n");

        for (int i = 0; i < data.Length - 1; i++)
        {
            minIndex = i;
            for (int j = i + 1; j < data.Length; j++)
            {
                if (data[j] < data[minIndex])
                {
                    minIndex = j;
                   
                }
            }
            temp = data[minIndex];
            data[minIndex] = data[i];
            data[i] = temp;
        }
        foreach (int i in data)
        {
            Console.WriteLine(i + " ");
        }
    }
}