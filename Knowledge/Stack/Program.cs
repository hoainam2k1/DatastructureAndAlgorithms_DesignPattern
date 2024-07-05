// LIFO (Last in First out) - Sử dụng để thực hiện các thao tác hoàn tác, xử lý biểu thức
using System;
using System.Collections;
public class SamplesStack
{
    public static void Main()
    {
        Stack stack = new Stack();
        stack.Push("Hello");
        stack.Push("World");
        stack.Push("!");

        // Display the properties and values of the stack
        Console.WriteLine("My stack");
        Console.WriteLine("\tCount: {0}", stack.Count);
        Console.WriteLine("\tValue:");
        PrintValues(stack);
    }
    public static void PrintValues(IEnumerable myCollection)
    {
        foreach (Object obj in myCollection)
            Console.Write("    {0}", obj);
        Console.WriteLine();
    }
}