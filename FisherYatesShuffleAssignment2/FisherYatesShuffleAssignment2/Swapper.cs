using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherYatesShuffleAssignment2
{
    public static class Swapper
    {
        public static void SwapValuesAtIndices(this object[] elements, int i, int j)
        {
            // Store value at index i in temp
            object temp = elements[i];
            // Set value at inex i to value at index j
            elements[i] = elements[j];
            // Set value at index j to temp
            elements[j] = temp;
        }
    }
}
