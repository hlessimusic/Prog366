using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Searching
{
    class Binary
    {
        // Class member variables.
        public int valueIndex = -1;
        private Stopwatch stopWatch = new Stopwatch();
        public TimeSpan runTime;
        private bool firstRun = true;

        public void binarySearch(int[] inputValues, int left, int right, int value)
        {
            // Check if first call on recursive stack.
            // If yes, start tracking runtime.
            if (firstRun)
            {
                stopWatch.Start();
                firstRun = false;
            }
            
            if (right >= left)
            {
                // Set mid point in array.
                int mid = ((left + right) / 2);

                //Check if midpoint is value being searched for.
                if (inputValues[mid] == value)
                {
                    valueIndex = mid;
                    stopWatch.Stop();
                    runTime = stopWatch.Elapsed;
                }

                // if the value at the middle index is larger than value being search for
                // recursively call method to search left half of array with new search bounds.
                if (inputValues[mid] > value)
                {
                    binarySearch(inputValues, left, mid - 1, value);
                }

                // if the value at the middle index is less than value being search for
                // recursively call method to search right half of array with new search bounds.
                if (inputValues[mid] < value)
                {
                    binarySearch(inputValues, mid + 1, right, value);
                }
            }
        }

    }
}
