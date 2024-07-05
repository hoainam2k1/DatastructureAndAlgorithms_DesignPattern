using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Multi_dimensional_Array
    {
        int[,] array2DDeclaration = new int[4, 2];

        int[,,] array3DDeclaration = new int[4, 2, 3];

        // Two-dimensional array
        int[,] array2DInitialization = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

        // Three-dimensional array
        int[,,] array3DInitialization = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

       
    }
}
