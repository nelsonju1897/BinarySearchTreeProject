using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSearch
{
    class Program
    {
        static void Main(string[] args)
        {

            //create new list
            //add data to list - is there a root? Yes - add to next part of tree. No - set root
            BinarySearchTree bst = new BinarySearchTree();
            bst.addNode(10);
            bst.addNode(5);
            bst.addNode(6);
            bst.addNode(11);
            bst.addNode(4);
            bst.addNode(2);
            bst.addNode(15);
            bst.addNode(100);
            bst.addNode(5);
            bst.addNode(10);
            Console.ReadLine();
        }
    }
}
