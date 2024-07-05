// FIFO (First in - First out) - Sử dụng trong quản lý tác vụ, hàng đợi in
using System;
using System.Collections;
public class SampleQueue
{
    public static void Main()
    {
        Queue myQ = new Queue();
        myQ.Enqueue("Hello");
        myQ.Enqueue("World");
        myQ.Enqueue("!");

        // Displays the properties and values of the Queue.
        Console.WriteLine("myQ");
        Console.WriteLine("\tCount:    {0}", myQ.Count);
        Console.Write("\tValues:");
        PrintValues(myQ);
    }
    public static void PrintValues(IEnumerable myCollection)
    {
        foreach (Object obj in myCollection)
            Console.Write("    {0}", obj);
        Console.WriteLine();
    }
}