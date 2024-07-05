using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Single_dimensional_ArrayAsArguments
    {
        static void DisplayArray(string[] array) => Console.WriteLine(string.Join(" ", array));

        //Change the array by reversing its elements
        static void ChangeArray(string[] array) => Array.Reverse(array);

        static void ChangeArrayElements(string[] array)
        {
            // Change the value of the first three array elemtents.
            array[0] = "Mon";
            array[1] = "Wed";
            array[0] = "Fir";
        }

        static void Main()
        {
            // Declare and initialize an array
            string[] weekDays = ["Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"];

            // Display the array elements
            DisplayArray(weekDays);
            Console.WriteLine();

            // Reverse the array
            ChangeArray(weekDays);
            // Display the array again to verify that it stays reversed
            Console.WriteLine("Array weekDays after the call ChangeArray:");
            DisplayArray(weekDays);
            Console.WriteLine();

            // Assign new values to individual array elements
            ChangeArrayElements(weekDays);
            // Display the array again to verify that it has changed
            Console.WriteLine("Array weekDays after the call ChangeArrayElements:");
            DisplayArray(weekDays);
        }

    }
}
