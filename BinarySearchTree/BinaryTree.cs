using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        Node current;
        Node root;
        public BinaryTree()
        {
            root = null;
        }
        public void InsertNode(int data)
        {
            if (root == null)
            {
                root = new Node(data);
            }
            else
            {
                current = root;

                while (current != null)
                {

                    if (data >= current.data)
                    {
                        if (current.rightChild == null)
                        {
                            current.rightChild = new Node(data);
                            return;
                        }
                        else
                        {
                            current = current.rightChild;
                        }
                    }
                    if (data < current.data)
                    {
                        if (current.leftChild == null)
                        {
                            current.leftChild = new Node(data);
                            return;
                        }
                        else
                        {
                            current = current.leftChild;
                        }
                    }

                }
            }
        }
        public bool SearchTree(int data)
        {
            
            if (root == null)
            {
                return false;
            }
            else
            {
                current = root;
            }
            while (current != null)
            {

                if (data > current.data)
                {
                    if (current.rightChild == null)
                    {

                        return false;
                    }
                    else
                    {
                        current = current.rightChild;
                    }
                }
                else if (data < current.data)
                {
                    if (current.leftChild == null)
                    {

                        return false;
                    }
                    else
                    {
                        current = current.leftChild;
                    }
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }

}

