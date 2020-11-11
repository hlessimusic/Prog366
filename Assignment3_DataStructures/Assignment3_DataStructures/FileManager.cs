using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment3_DataStructures
{
    class FileManager
    {
        public string filePath;
        public string[] testArray;

        //Fill array with data from file
        public void loadFileToArray(string inputPath)
        {
            filePath = inputPath;
            testArray = File.ReadAllText(filePath).Split('\t').ToArray();
        }
    }
}
