using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7._3
{
    internal class Node
    {
        public int value;
        public Node left;
        public Node right;

        public Node(int value)
        {
            this.value = value;
            left = null;
            right = null;
        }
    }
    internal class BST
    {
        public Node root; // starting point
        public BST()
        {
            root = null;
        }
        public void InsertNewNode(Node tempRoot, int val)
        {
            Node node = new Node(val);
            Node temp = null;
            if (root != null)
            {
                while (tempRoot != null)
                {
                    temp = tempRoot;
                    if (tempRoot.value == val)
                    {
                        Console.WriteLine("Value already exists in the tree.");
                        return; // value already exists, do not insert again
                    }
                    else if (val < tempRoot.value)
                    {
                        tempRoot = tempRoot.left; // go left
                    }
                    else
                    {
                        tempRoot = tempRoot.right; // go right
                    }

                }
                if (val < temp.value)
                {
                    temp.left = node; // insert as left child
                }
                else
                {
                    temp.right = node; // insert as right child
                }
            }
            else
            {
                root = node; // if tree is empty, set root to new node
            }
        }
        public void InOrderTraversal(Node tempRoot) //DFS
        {
            if (tempRoot != null)
            {
                InOrderTraversal(tempRoot.left);
                Console.Write(tempRoot.value + " ");
                InOrderTraversal(tempRoot.right);
            }
        }
        public void PreOrderTraversal(Node tempRoot) //DFS
        {
            if (tempRoot != null)
            {
                Console.Write(tempRoot.value + " ");
                InOrderTraversal(tempRoot.left);
                InOrderTraversal(tempRoot.right);
            }
        }
        public void PostOrderTraversal(Node tempRoot) //DFS
        {
            if (tempRoot != null)
            {
                InOrderTraversal(tempRoot.left);
                InOrderTraversal(tempRoot.right);
                Console.Write(tempRoot.value + " ");
            }
        }
        public bool TrySearch(int val, out Node temp)
        {
            temp = root;
            while (temp != null)
            {
                if (temp.value == val)
                {
                    return true;
                }
                else if (val < temp.value)
                {
                    temp = temp.left;
                }
                else
                {
                    temp = temp.right;
                }
            }
            Console.Error.WriteLine("\nValue does not exist in current context");
            return false;
        }
    }
}
