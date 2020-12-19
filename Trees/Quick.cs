using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    // Quick sorting algorithm class.
    class Quick
    {

        // Creates partition in array, places pivot element into correct point in sorted array
        // places smaller elements left, and larger elements right.
        private int Partition(int[] inputValues, int low, int high)
        {
            // Variable assignment/declaration.
            int pivot, index, tempVal_1, tempVal_2;
            pivot = inputValues[high];

            // Set index of smaller element.
            index = low - 1;
            for (int i = low; i < high; i++)
            {
                // Swap element at index with element at i if element at i is smaller than pivot.
                if (inputValues[i] < pivot)
                {
                    // increment index by 1.
                    index++;

                    // Perform element swap.
                    tempVal_1 = inputValues[index];
                    inputValues[index] = inputValues[i];
                    inputValues[i] = tempVal_1;
                }
            }

            // Swap element at next index with pivot.
            tempVal_2 = inputValues[index + 1];
            inputValues[index + 1] = inputValues[high];
            inputValues[high] = tempVal_2;

            // returns index of partition
            return index + 1;

        }

        // Quick sort Algorithm. 
        // Comparison-based. 
        // Sort-in-place. 
        // Divide-and-conquer.
        public void QuickSort(int[] inputValues, int low, int high)
        {

            if (low < high)
            {
                // Call Partion method and set return value to partition index.
                int PartIndex = Partition(inputValues, low, high);

                // Recursively sort elements first before and then after partition.
                QuickSort(inputValues, low, PartIndex - 1);
                QuickSort(inputValues, PartIndex + 1, high);
            }
        }
    }
}
