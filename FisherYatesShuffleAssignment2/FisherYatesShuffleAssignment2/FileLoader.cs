using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FisherYatesShuffleAssignment2
{
    public static class FileLoader
    {
        // Variable declaration for array of strings.
        private static string[] elements = new string[10];

        // readFileToArray method declaration. Loads elements with data from file located at inputFilePath.
        public static void readFileToArray(string inputFilePath)
        {
            // Starting at the first index, assign input stream from file at inputFilePath to value at current index. Increments current index with line break in file.
            elements = File.ReadAllLines(inputFilePath);
        }

        // GetArray method declaration. Returns elements array.
        public static string[] GetArray()
        {
            return elements;
        }


        public static void printArray()
        {
            // Iterate over elements.
            for (int i = 0; i<= 9; i++)
            {
                // Prints value in elements at index i to the console.
                Console.WriteLine(elements[i]);
            }
        }
    }
}
