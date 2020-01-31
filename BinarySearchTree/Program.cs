using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.InsertNode(75);
            binaryTree.InsertNode(42);
            binaryTree.InsertNode(32);
            binaryTree.InsertNode(67);
            binaryTree.InsertNode(54);
            binaryTree.InsertNode(32);
            Console.WriteLine(binaryTree.SearchTree(67));
            Console.ReadLine();
        }
    }
}
