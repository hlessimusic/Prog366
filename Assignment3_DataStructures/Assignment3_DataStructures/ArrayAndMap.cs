using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_DataStructures
{
    class ArrayAndMap
    {
        public static Hashtable myHash = new Hashtable();
        public static LinkedList<string> myList = new LinkedList<string>();

        //Adding Elements to Table
        public void addElementToTable(string inputValue, int inputKey)
        {
            myHash.Add(inputKey, inputValue);
        }

        //Adding elements to Linked List
        public void addElementToList(string inputValue)
        {
            myList.AddLast(inputValue);
        }
    }
}
