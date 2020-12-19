using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    class Node
    {
        // Node Class member variables.
        private Node leftChild;
        private Node rightChild;
        private int value;

        // get member methods.
        public Node getLeftChild()
        {
            return leftChild;
        }

        public Node getRightChild()
        {
            return rightChild;
        }

        public int getNodeValue()
        {
            return value;
        }


        // Set member methods
        public void setLeftChild(Node inputNode)
        {
            leftChild = inputNode;
        }

        public void setRightChild(Node inputNode)
        {
            rightChild = inputNode;
        }

        public void setNodeValue(int inputValue)
        {
            value = inputValue;
        }
    }
}
