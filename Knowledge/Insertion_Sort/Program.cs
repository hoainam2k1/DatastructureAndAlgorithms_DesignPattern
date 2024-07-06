using System;
public class SampleInsertionSort
{
    static void Main()
    {
        int[] data = new int[10];
        Random rand = new Random();
        int val = 0;
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = rand.Next(20, 90);
        }

        foreach (int i in data)
        {
            Console.WriteLine(i + " ");
        }
        Console.WriteLine("\n\n");

        for (int i = 1; i < data.Length - 1; i++)
        {
            val = data[i];
            for (int j = i - 1; j >= 0; )
            {
                if (val < data[j])
                {
                    data[j + 1] = data[j];
                    j--;
                    data[j + 1] = val;
                }
                else
                {
                    break;
                }
            }
        }
        foreach (int i in data)
        {
            Console.WriteLine(i + " ");
        }
    }
}