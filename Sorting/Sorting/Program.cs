using System;
using System.IO;

namespace Sorting
{
    class Program
    {
        // Variable declarations/assignments
        static int SIZE = 474;
        static string filePath = "..\\scores.txt";
        static StreamReader myStreamReader = new StreamReader(filePath);
        static int[] dataSet = new int[SIZE];
        static string currLine;
        static DataManager myDataManager = new DataManager();
        static Bubble myBubbleSort = new Bubble();
        static Insertion myInsertionSort = new Insertion();
        static Selection mySelectionSort = new Selection();
        static Heap myHeapSort = new Heap();
        static Quick myQuickSort = new Quick();
        static Merge myMergeSort = new Merge();

        static void Main()
        {
            // Program Entry Point

            // Populates dataSet with values from scores.txt
            for (int i = 0; i < SIZE; i++)
            {
                currLine = myStreamReader.ReadLine();
                dataSet[i] = int.Parse(currLine);
            }

            // Display unsorted data set.
            Console.WriteLine("Unsorted Data Set");
            Console.WriteLine("[{0}]", string.Join(", ", dataSet));
            Console.WriteLine("\n");

            // Executes Bubble Sort algorithm on copy of dataSet
            myBubbleSort.BubbleSort(myDataManager.CopyData(dataSet));
            Console.WriteLine("Bubble Sort Method");
            Console.WriteLine("Asymptotic Notation");
            Console.WriteLine(" Best Case: O(n^2)");
            Console.WriteLine("Worst Case: O(n^2)");
            myDataManager.displayData();
            Console.WriteLine("Executed in: " + myBubbleSort.runTime);
            Console.WriteLine("\n");

            // Executes Insertion Sort algorithm on copy of dataSet
            myInsertionSort.InsertionSort(myDataManager.CopyData(dataSet));
            Console.WriteLine("Insertion Sort Method");
            Console.WriteLine("Asymptotic Notation");
            Console.WriteLine(" Best Case: O(n)");
            Console.WriteLine("Worst Case: O(n^2)");
            myDataManager.displayData();
            Console.WriteLine("Executed in: " + myInsertionSort.runTime);
            Console.WriteLine("\n");

            // Executes Selection Sort algorithm on copy of dataSet
            mySelectionSort.SelectionSort(myDataManager.CopyData(dataSet));
            Console.WriteLine("Selection Sort Method");
            Console.WriteLine("Asymptotic Notation");
            Console.WriteLine(" Best Case: O(n^2)");
            Console.WriteLine("Worst Case: O(n^2)");
            myDataManager.displayData();
            Console.WriteLine("Executed in: " + mySelectionSort.runTime);
            Console.WriteLine("\n");

            // Executes Heap Sort algorithm on copy of dataSet
            myHeapSort.HeapSort(myDataManager.CopyData(dataSet));
            Console.WriteLine("Heap Sort Method");
            Console.WriteLine("Asymptotic Notation");
            Console.WriteLine(" Best Case: O(n log n)");
            Console.WriteLine("Worst Case: O(n log n)");
            myDataManager.displayData();
            Console.WriteLine("Executed in: " + myHeapSort.runTime);
            Console.WriteLine("\n");

            // Executes Quick Sort algorithm on copy of dataSet
            myQuickSort.QuickSort(myDataManager.CopyData(dataSet), dataSet.GetLowerBound(0), dataSet.GetUpperBound(0));
            Console.WriteLine("Quick Sort Method");
            Console.WriteLine("Asymptotic Notation");
            Console.WriteLine(" Best Case: O(n log n)");
            Console.WriteLine("Worst Case: O(n^2)");
            myDataManager.displayData();
            Console.WriteLine("Executed in: " + myQuickSort.runTime);
            Console.WriteLine("\n");

            // Executes Merge Sort algorithm on copy of dataSet
            myMergeSort.SortHalfs(myDataManager.CopyData(dataSet), dataSet.GetLowerBound(0), dataSet.GetUpperBound(0));
            Console.WriteLine("Merge Sort Method");
            Console.WriteLine("Asymptotic Notation");
            Console.WriteLine(" Best Case: O(n log n)");
            Console.WriteLine("Worst Case: O(n log n)");
            myDataManager.displayData();
            Console.WriteLine("Executed in: " + myMergeSort.runTime);
            Console.WriteLine("\n");

            // Outputs table of algorithm names and their runtimes.
            Console.WriteLine("___Algorithm____|____Runtimes_______");
            Console.WriteLine("   Bubble       |   " + myBubbleSort.runTime);
            Console.WriteLine("  Insertion     |   " + myInsertionSort.runTime);
            Console.WriteLine("  Selection     |   " + mySelectionSort.runTime);
            Console.WriteLine("    Heap        |   " + myHeapSort.runTime);
            Console.WriteLine("    Quick       |   " + myQuickSort.runTime);
            Console.WriteLine("    Merge       |   " + myMergeSort.runTime);

            // Program exit.
        }
    }
}
