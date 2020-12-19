using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Sorting
{
    class Selection
    {
        private Stopwatch stopWatch = new Stopwatch();
        public TimeSpan runTime;

        public void SelectionSort(int[] inputValues)
        {
            // Start tracking runtime of sorting algorithm.
            stopWatch.Start();
            int min_Index;
            int tempValue;

            // Goal is to find index of minimum value that still needs to be sorted.
            // iterates over array, i = index of value currently being evaluated for sorting.
            for(int i = 0; i < inputValues.Length - 1; i++)
            {
                min_Index = i;
                // iterate over array j = index of value for i to be compared with.
                for (int j = i + 1; j < inputValues.Length; j++)
                {
                    // if value at j is smaller than value at i, then j and not i, is value that needs to be moved this iteration.
                    if(inputValues[j] < inputValues[min_Index])
                    {
                        min_Index = j;
                    }
                }

                //Swaps values into correct position in array.
                tempValue = inputValues[min_Index];
                inputValues[min_Index] = inputValues[i];
                inputValues[i] = tempValue;
            }
            // Stop tracking runtime when algorithm is finished. 
            stopWatch.Stop();
            runTime = stopWatch.Elapsed;
        }
    }
}
