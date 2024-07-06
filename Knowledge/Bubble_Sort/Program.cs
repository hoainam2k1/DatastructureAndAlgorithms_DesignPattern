using System;
public class SampleBubbleSort
{
    static void Main(string[] arrays)
    {
        int Count = 0;
        int[] intArray = new int[5];

        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = int.Parse(Console.ReadLine());
        }
        // sorting the array
        for (int j = 0; j <= intArray.Length - 2; j++)
        {
            //intArray.Length - 2
            for (int i = 0; i <= intArray.Length - 2; i++)
            {
                Count = Count + 1;
                if (intArray[i] > intArray[i + 1])
                {
                    int temp = intArray[i + 1];
                    intArray[i + 1] = intArray[i];
                    intArray[i] = temp;
                }
            }
        }
        Console.WriteLine("After Sorting Array :");
        foreach (int item in intArray)
        {
            Console.Write(item + " ");
        }
       
    }
}