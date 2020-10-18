using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FisherYatesShuffleAssignment2
{
    class Program
    {
        // Program entry point.
        static void Main()
        {           
            // Assigns path for file to be read.
            const string path = @"..\\Resources\\TestValues.txt";
            // Load file to array.
            FileLoader.readFileToArray(path);
            // Shuffle array.
            FisherYatesShuffler.DoFisherYatesShuffle(FileLoader.GetArray());
            // Print array.
            FileLoader.printArray();
            // Display Console until user presses key.
            Console.ReadLine();
        }
    }
}
