using System;
using System.Globalization;
public class SampleHeapSort
{
    static void heapSort(int[] arr, int n)
    {
        for (int i = n / 2 - 1; i >= 0; i--)
            heapify(arr, n, i);
        for (int i = n - 1; i >= 0; i--)
        {
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;
            heapify(arr, i, 0);
        }
    }
    static void heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;
        if (left < n && arr[left] > arr[largest])
            largest = left;
        if (right < n && arr[right] > arr[largest])
            largest = right;
        if (largest != i)
        {
            int swap = arr[i];
            arr[i] = arr[largest];
            arr[largest] = swap;
            heapify(arr, n, largest);
        }
    }
    public static void Main()
    {
        int[] data = new int[10];
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
       
        heapSort(data, data.Length);
        Console.Write("Sorted Array is: ");
        foreach (int i in data)
        {
            Console.WriteLine(i + " ");
        }
    }
}