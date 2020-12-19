using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Searching
{
    class Interpolation
    {
        // Class member variables.
        public int valueIndex = -1;
        private Stopwatch stopWatch = new Stopwatch();
        public TimeSpan runTime;
        private bool firstRun = true;

        public void interpolationSearch(int[] inputValues, int low, int high, int value)
        {
            // Check if first call on recursive stack.
            // If yes, start tracking runtime.
            if (firstRun)
            {
                stopWatch.Start();
                firstRun = false;
            }

            int position;

            if (low <= high && value >= inputValues[low] && value <= inputValues[high])
            {
                // Formula for starting search position in array.
                position = low + ((high - high)) / (inputValues[high] - inputValues[low]) * (value - inputValues[low]);

                // If value at starting position is value to be found
                // value index is position.
                if (inputValues[position] == value)
                {
                    valueIndex = position;

                    //Stop tracking runtime. Algorithm complete.
                    stopWatch.Stop();
                    runTime = stopWatch.Elapsed;
                }

                // If value at starting position is less than value to be found
                // recursively call interpolationSearch with new array bounds
                if (inputValues[position] < value)
                {
                    interpolationSearch(inputValues, position + 1, high, value);
                }

                // If value at starting position is greater than value to be found
                // recursively call interpolationSearch with new array bounds
                if (inputValues[position] > value)
                {
                    interpolationSearch(inputValues, low, position - 1, value);
                }
            }
        }
    }
}
