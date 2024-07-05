using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Multi_dimensional_ArrayAsArgument
    {
        static void Print2DArray(int[,] array)
        {
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    System.Console.WriteLine("Element({0},{1})={2}", i, j, array[i, j]);
                }
            }
        }
        static void ExampleUsage()
        {
            // Pass the array as an argument.
            Print2DArray(new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } });
        }
    }
}
