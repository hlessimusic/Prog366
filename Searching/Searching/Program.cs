using System;
using System.IO;

namespace Searching
{
    class Program
    {
        // Variable declaration/assignment.
        static int[] dataSet = { 0, 1, 12, 23, 41, 55, 60, 79, 82, 90 };
        static int userValue;
        static dataManager myDataManager = new dataManager();
        static Linear myLinearSearch = new Linear();
        static Binary myBinarySearch = new Binary();
        static Interpolation myInterpolationSearch = new Interpolation();

        static void Main()
        {
            // Program entry point.

            //Displays data set to be search and queries user for value to search for in array.
            myDataManager.CopyData(dataSet);
            myDataManager.displayData();
            userValue = myDataManager.getUserValue();
            Console.WriteLine("\n");

            // Executes linear search and displays algorithm info.
            myLinearSearch.linearSearch(myDataManager.CopyData(dataSet), userValue);
            Console.WriteLine("Linear Search Method");
            Console.WriteLine("Asymptotic Notation");
            Console.WriteLine(" Best Case: O(1)");
            Console.WriteLine("Worst Case: O(n)");
            Console.WriteLine(userValue + " is located at index " + myLinearSearch.valueIndex);
            Console.WriteLine("Executed in: " + myLinearSearch.runTime);
            Console.WriteLine("\n");

            // Executes binary search and displays algorithm info.
            myBinarySearch.binarySearch(myDataManager.CopyData(dataSet), dataSet.GetLowerBound(0), dataSet.GetUpperBound(0), userValue);
            Console.WriteLine("Binary Search Method");
            Console.WriteLine("Asymptotic Notation");
            Console.WriteLine(" Best Case: O(1)");
            Console.WriteLine("Worst Case: O(log n)");
            Console.WriteLine(userValue + " is located at index " + myBinarySearch.valueIndex);
            Console.WriteLine("Executed in: " + myBinarySearch.runTime);
            Console.WriteLine("\n");

            // Executes interpolation search and displays algorithm info.
            myInterpolationSearch.interpolationSearch(myDataManager.CopyData(dataSet), dataSet.GetLowerBound(0), dataSet.GetUpperBound(0), userValue);
            Console.WriteLine("Interpolation Search Method");
            Console.WriteLine("Asymptotic Notation");
            Console.WriteLine(" Best Case: O(log log n)");
            Console.WriteLine("Worst Case: O(n)");
            Console.WriteLine(userValue + " is located at index " + myInterpolationSearch.valueIndex);
            Console.WriteLine("Executed in: " + myInterpolationSearch.runTime);
            Console.WriteLine("\n");

            // Outoputs table of algorithm names and their runtimes.
            Console.WriteLine("___Algorithm____|____Runtimes_______");
            Console.WriteLine("   Linear       |   " + myLinearSearch.runTime);
            Console.WriteLine("   Binary       |   " + myBinarySearch.runTime);
            Console.WriteLine("Interpolation   |   " + myInterpolationSearch.runTime);
        }
    }
}
