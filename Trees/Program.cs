using System;

namespace Trees
{
    class Program
    {
        static void Main()
        {
            // Program entry point.

            // Variable declaration/assignment
            int[] myDataSet;
            dataManager myDataManager = new dataManager();
            binaryTree myBinaryTree = new binaryTree();
            Quick myQuickSort = new Quick();

            myDataSet = myDataManager.readFile();

            // Displays data set before sorting or binary tree construction.
            Console.WriteLine("Initial Data Set:");
            for (int i = 0; i < myDataSet.Length; i++)
            {
                Console.Write(myDataSet[i] + " ");
            }
            Console.WriteLine("\n");

            // Display sorted data set.
            // Sorted with Quick sort method.
            Console.WriteLine("Sorted Data Set:");
            myQuickSort.QuickSort(myDataSet, myDataSet.GetLowerBound(0), myDataSet.GetUpperBound(0));
            for (int i = 0; i < myDataSet.Length; i++)
            {
                Console.Write(myDataSet[i] + " ");
            }
            Console.WriteLine("\n");

            // Iterate over data set and construct binary tree data structure.
            for (int i = 0; i < myDataSet.Length; i++)
            {
                // add node with value at index i to position in tree. 
                myBinaryTree.addChild(myDataSet[i]);
            }

            // Displays data set by PreOrder traversal. 
            // First Root
            // Left subtree
            // Right subtree
            Console.WriteLine("PreOrder Traversal (Root -> left subtree -> right subtree)");
            myBinaryTree.traverseTree(myBinaryTree.getRoot());
            Console.WriteLine("\n");

            // End of Main.
        }
    }
}
