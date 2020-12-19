using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Sorting
{
    class Bubble
    {
        // Variable declarations/assignments
        public bool notSorted = true;
        private int tempValue;
        private Stopwatch stopWatch = new Stopwatch();
        public TimeSpan runTime;

        // Bubble Sort Method.
        // Starts at beginning of inputData, swaps the first two elements
        // if first element is greater than the next element. 
        // Then evaluates the next pair, and so on until full array is sorted.
        public void BubbleSort(int[] inputData)
        {
            // Start tracking Bubble Sort algorithm runtime
            stopWatch.Start();

            // loops until array is sorted.
            while (notSorted)
            {
                
                notSorted = false;

                for (int i = 0; i < inputData.Length - 1; i++)
                {
                    for (int j = 0; j < inputData.Length - i - 1; j++)
                    {
                        if (inputData[j] > inputData[j + 1])
                        {
                            tempValue = inputData[j];
                            inputData[j] = inputData[j + 1];
                            inputData[j + 1] = tempValue;
                            notSorted = true;
                        }
                    }
                }
            }
            // Stop tracking runtime when algorithm has sorted array.
            stopWatch.Stop();
            runTime = stopWatch.Elapsed;
        }

    }
}
