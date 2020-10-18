using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherYatesShuffleAssignment2
{
    public static class FisherYatesShuffler
    {
        // randNum variable declaration and assignment to new random.
        private static Random randomNum = new Random();

        // DoFisherYatesShuffle method declaration
        public static void DoFisherYatesShuffle(this object[] elements)
        {
            // Loop over array.
            for (int i = elements.Length - 1; i > 0; i--)
            {
                // set value of j to a random index number between 0 and 9
                int j = GetRandomNum(i);
                // Swaps values at indices i and j
                elements.SwapValuesAtIndices(i, j);
            }
        }

        // GetRandomNum method declaration.
        private static int GetRandomNum(int i)
        {
            // return random number less than i + 1
            return randomNum.Next(i + 1);
        }

    }
}
