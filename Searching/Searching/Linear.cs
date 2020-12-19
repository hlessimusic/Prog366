using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Searching
{
    class Linear
    {
        // Class member Variables.
        public int valueIndex = -1;
        private Stopwatch stopWatch = new Stopwatch();
        public TimeSpan runTime;
        
        // Linear searching algorithm.
        // Sequantially checks each element in the data set until input value is locatedin array.
        public void linearSearch(int[] inputValues, int value)
        {
            // Start tracking runtime.
            stopWatch.Start();
            int SIZE = inputValues.Length;

            // Iterate over array until input value is found at index i.
            for(int i = 0; i < SIZE; i++)
            {
                if (inputValues[i] == value)
                {
                    valueIndex = i;

                    // Stop tracking runtime. Algorithm complete.
                    stopWatch.Stop();
                    runTime = stopWatch.Elapsed;
                }
            }
        }

    }
}
