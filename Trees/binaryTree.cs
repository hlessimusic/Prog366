using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    class binaryTree
    {
        // Class member variable
        private Node Root;
        public Node before;
        public Node after;

        public Node getRoot()
        {
            return Root;
        }

        public void setRoot(Node inputNode)
        {
            Root = inputNode;
        }

        // Primary Method for constructing binary tree data structure.
        // Creates node with value of given input value.
        // Places node into respective position in tree.
        public bool addChild(int inputValue)
        {
            before = null;
            after = this.Root;

            // if there are nodes bellow in tree structure
            while (after != null)
            {
                // push node up tree
                before = after;


                if (inputValue < after.getNodeValue())
                {
                    after = after.getLeftChild();
                }
                else if (inputValue > after.getNodeValue())
                {
                    after = after.getRightChild();
                }
                else
                {
                    // This should never run.
                    return false;
                }
            }

            // Create new node with value of inputValue
            Node newChild = new Node();
            newChild.setNodeValue(inputValue);

            // If there is no Root node yet (first node placed in Tree), the newly created node is the Root. 
            if(this.Root == null)
            {
                // Only runs once upon starting tree construction.
                this.Root = newChild;
            }
            else
            {
                // Root exists so newly created node is added further down tree.

                if(inputValue < before.getNodeValue())
                {
                    before.setLeftChild(newChild);
                }
                else
                {
                    before.setRightChild(newChild);
                }
            }
            return true;
        }

        // Locates node with given input value and returns it.
        // Evokes findFromParent private method to locate node.
        public Node findNode(int inputValue)
        {
            return this.findFromParent(inputValue, this.Root);
        }

        // Removes node with value of given input value.
        // Evokes removeByValue private method to remove node.
        public void removeNode(int inputValue)
        {
            this.Root = removeByValue(this.Root, inputValue);
        }

        // Searches tree structure at parent for node with value of given input value.
        private Node removeByValue(Node parent, int inputValue)
        {
            if (parent == null)
            {
                return parent;
            }

            if (inputValue < parent.getNodeValue())
            {
                parent.setLeftChild(removeByValue(parent.getLeftChild(), inputValue));
            }
            else if (inputValue > parent.getNodeValue())
            {
                parent.setRightChild(removeByValue(parent.getRightChild(), inputValue));
            }
            else
            {
                if (parent.getLeftChild() == null)
                {
                    return parent.getRightChild();
                }
                else if(parent.getRightChild() == null)
                {
                    return parent.getLeftChild();
                }

                parent.setNodeValue(minimumValue(parent.getRightChild()));

                parent.setRightChild(removeByValue(parent.getRightChild(), parent.getNodeValue()));
            }

            return parent;
        }

        // Returns min node value in tree data structure.
        private int minimumValue(Node inputNode)
        {
            int minVal = inputNode.getNodeValue();

            // loops until leftmost node in tree is reached
            while(inputNode.getLeftChild() != null)
            {
                minVal = inputNode.getLeftChild().getNodeValue();
                inputNode = inputNode.getLeftChild();
            }

            return minVal;
        }

        // Returns input Parent node if parent node's value is input value
        // Recursively calls itself until the node with input value is returned
        // or the node does not exist in tree.
        private Node findFromParent(int inputValue, Node inputParent)
        {
            if(inputParent != null)
            {
                if (inputValue == inputParent.getNodeValue())
                {
                    return inputParent;
                }
                if (inputValue < inputParent.getNodeValue())
                {
                    // Recursive call going down left branch.
                    return findFromParent(inputValue, inputParent.getLeftChild());
                }
                else
                {
                    // Recursive call going down right branch.
                    return findFromParent(inputValue, inputParent.getRightChild());
                }
            }

            
            return null;
        }

        // Traverse tree structure by PreOrder traversal and display entire binary tree structure.
        // Always displays Root node first.
        // Then left subtree.
        // Then right subtree.
        public void traverseTree(Node inputParent)
        {
            if (inputParent != null)
            {
                Console.Write(inputParent.getNodeValue() + " ");
                traverseTree(inputParent.getLeftChild());
                traverseTree(inputParent.getRightChild());
            }
        }
    }
}
