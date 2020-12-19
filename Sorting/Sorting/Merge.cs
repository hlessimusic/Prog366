using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Sorting
{
    class Merge
    {
        // Variable declaration/assignment.
        private Stopwatch stopWatch = new Stopwatch();
        public TimeSpan runTime;
        private bool firstRun = true;

        // Merges subarrays 
        public void ExecMerge(int[] inputValues, int left, int mid, int right)
        {
            // Calculate sizes of subarrays.
            int subArr1_SIZE, subArr2_SIZE, i, j, k;
            subArr1_SIZE = mid - left + 1;
            subArr2_SIZE = right - mid;

            // Create temp arrays to be merged 
            int[] leftSubArr, rightSubArr;
            leftSubArr = new int[subArr1_SIZE];
            rightSubArr = new int[subArr2_SIZE];

            // Copy elements into temp arrays
            for (i = 0; i < subArr1_SIZE; ++i)
                leftSubArr[i] = inputValues[left + i];
            for (j = 0; j < subArr2_SIZE; ++j)
                rightSubArr[j] = inputValues[mid + 1 + j];

            i = 0;
            j = 0;
            k = left;

            // Merge subarrays by copying to inputArray. i used for index of value to be copied from left subarray, 
            // j for index of value to be copied from right subarray
            while (i < subArr1_SIZE && j < subArr2_SIZE)
            {
                if (leftSubArr[i] <= rightSubArr[j])
                {
                    inputValues[k] = leftSubArr[i];
                    i++;
                }
                else
                {
                    inputValues[k] = rightSubArr[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements from leftSubArr
            while(i < subArr1_SIZE)
            {
                inputValues[k] = leftSubArr[i];
                i++;
                k++;
            }

            // Copy remaining elements from rightSubArr
            while(j < subArr2_SIZE)
            {
                inputValues[k] = rightSubArr[j];
                j++;
                k++;
            }
        }

        // Main method for algorithm method, recursive calls to sort array, then evokes execMerge to 
        //first sorts left side of array, then sorts right
        public void SortHalfs(int[] inputValues, int left, int right)
        {
            // Start tracking runtime on sorting algorithm start.
            if (firstRun)
            {
                stopWatch.Start();
                firstRun = false;
            }

            int mid;

            // Recursively calls SortHalfs until correct midpoint index, then executes merge of subarrays.
            if (left < right)
            {
               // Calculate mid index.
                mid = ((left + right) / 2);

                // Recursive calls to find midpoint.
                SortHalfs(inputValues, left, mid);
                SortHalfs(inputValues, mid + 1, right);

                // Execute merge
                ExecMerge(inputValues, left, mid, right);

                // Stop tracking runtime when algorithm has sorted array.
                stopWatch.Stop();
                runTime = stopWatch.Elapsed;
            }
        }
    }
}
