using System;
using System.Collections.Generic;
using System.Text;

namespace Searching
{
    // Helper class to manager data in program.
    class dataManager
    {
        // Class member variable declaration/assignment.
        public int[] dataCopy = new int[10];

        // Helper method to copy data in input array to dataCopy array.
        public int[] CopyData(int[] inputData)
        {
            // Iterate over array to copy data.
            for (int i = 0; i < inputData.Length; i++)
            {
                dataCopy[i] = inputData[i];
            }

            return dataCopy;
        }

        public void displayData()
        {
            Console.WriteLine("[{0}]", string.Join(", ", dataCopy));
        }

        // Queries user for value to be searched. 
        public int getUserValue()
        {
            int value;
            Console.WriteLine("Input value that you would like to find:");

            // Loop until user enters valid input.
            while (true)
            {
                // Check input is valid. 
                if (Int32.TryParse(Console.ReadLine(), out value))
                {
                    return value;
                }
                else
                    Console.WriteLine("Invalid input. Please input a value in list.");
            }
        }
    }
}
