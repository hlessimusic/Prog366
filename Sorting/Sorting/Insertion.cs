using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Sorting
{
    class Insertion
    {
        // Variable declaration/assignment.
        private int tempValue;
        private Stopwatch stopWatch = new Stopwatch();
        public TimeSpan runTime;

        // Insertion sort algorithm. 
        public void InsertionSort(int[] inputValues)
        {
            // Start tracking Bubble Sort algorithm runtime
            stopWatch.Start();

            // Iterate over array. i is used for index of current element to be moved.
            for (int i = 0; i < inputValues.Length - 1; i++)
            {
                // Iterate over unsorted portion of array for comparison
                for(int j = i + 1; j > 0; j--)
                {
                    // Swap element at index j - 1 (i) with element at index j (i + 1) if it's larger.
                    if(inputValues[j - 1] > inputValues[j])
                    {
                        tempValue = inputValues[j - 1];
                        inputValues[j - 1] = inputValues[j];
                        inputValues[j] = tempValue;
                    }
                }
            }
            // Stop tracking runtime when algorithm has sorted array.
            stopWatch.Stop();
            runTime = stopWatch.Elapsed;
        }
    }
}
