using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    // Data manager is a helper class.
    // Manages data in program.
    class DataManager
    {
        public int[]  dataCopy = new int[474];

        // copy data returns an new array that is a copy of the array it is passed.
        public int[] CopyData(int[] inputData)
        {

            for(int i = 0; i < inputData.Length; i++)
            {
                dataCopy[i] = inputData[i];
            }
            return dataCopy;
        }

        // Outputs array to the console as a long comma delimited list for readability.
        public void displayData()
        {
            Console.WriteLine("[{0}]", string.Join(", ", dataCopy));
        }
    }
}
