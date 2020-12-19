using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Sorting
{
    class Heap
    {
        private Stopwatch stopWatch = new Stopwatch();
        public TimeSpan runTime;

        // Heap sorting algorithm.
        // Comparison based sorting algorithm, uses a binary heap data structure.
        // First locates largest element in array and places at the end of the heap.
        // Then repeats this process for each element in the array
        public void HeapSort(int[] inputValues)
        {
            // Start tracking heap sort algorithm runtime
            stopWatch.Start();
            int SIZE = inputValues.Length;

            // Rearrange array to build heap.
            for(int i = SIZE / 2 - 1; i >= 0; i--)
            {
                heapify(inputValues, SIZE, i);
            }

            // In each iteration extract element from heap
            for(int i = SIZE - 1; i > 0; i--)
            {
                // Move current root to end
                int temp = inputValues[0];
                inputValues[0] = inputValues[i];
                inputValues[i] = temp;

                // call heapify on reduced heap
                heapify(inputValues, i, 0);
            }

            // Stop tracking runtime when algorithm has sorted array.
            stopWatch.Stop();
            runTime = stopWatch.Elapsed;
        }

        // Heapify takes an array of set size and constructs a Heap data structure with root at the index position of node.
        // Calls itself recursively to build the heap top down.
        private void heapify(int[] inputValues, int SIZE, int node)
        {
            int parent, leftChild, rightChild;
            parent = node;
            leftChild = 2 * node + 1;
            rightChild = 2 * node + 2;

            // Sets leftChild as the new parent if it is larger than current parent.
            if (leftChild < SIZE && inputValues[leftChild] > inputValues[parent])
            {
                parent = leftChild;
            }
             // Sets rightChild as the new parent if it is larger than current parent.
            if (rightChild < SIZE && inputValues[rightChild] > inputValues[parent])
            {
                parent = rightChild;
            }

            // Moves elements to correct positions in heap.
            // Recursively calls heapify with next node.
            if (parent != node)
            {
                int temp = inputValues[node];
                inputValues[node] = inputValues[parent];
                inputValues[parent] = temp;

                heapify(inputValues, SIZE, parent);
            }
        }
    }
}
