using System;
public class SampleQuickSort
{
    private static void Quick_Sort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(arr, left, right);

            if (pivot > 1)
            {
                Quick_Sort(arr, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                Quick_Sort(arr, pivot + 1, right);
            }
        }

    }
    private static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[left];
        while (true)
        {

            while (arr[left] < pivot)
            {
                left++;
            }

            while (arr[right] > pivot)
            {
                right--;
            }

            if (left < right)
            {
                if (arr[left] == arr[right]) return right;

                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;


            }
            else
            {
                return right;
            }
        }
    }
    static void Main()
    {
        int[] data = new int[10];
        int left = 0, right = data.Length - 1;
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

        Quick_Sort(data, left, right);
        foreach (int i in data)
        {
            Console.WriteLine(i + " ");
        }
    }
}