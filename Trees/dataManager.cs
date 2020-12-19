using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Trees
{
    // Helper Class that managers data in program.
    class dataManager
    {
        // Class member variables.
        private static int SIZE = 474;
        public int[] dataCopy = new int[SIZE];
        private string currLine;
        private string filePath = "..\\scores.txt";

        // Reads scores.txt copies into dataCopy array for use in Main program.
        // returns dataCopy array.
        public int[] readFile()
        {
            StreamReader dataFile = new StreamReader(filePath);
        
            for(int i = 0; i < SIZE; i++)
            {
                currLine = dataFile.ReadLine();
                dataCopy[i] = int.Parse(currLine);
            }

            return dataCopy;
        }
    }
}

