using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSearch
{
    class BinarySearchTree
    {
        public Node root;
        

        public void addNode(int data)
        {
            Node newNode = new Node(data);
            newNode.item = data;
            if(root == null)
            {
                root = newNode;
                return;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if(data <= current.item)
                    {
                        current = current.left;
                        if(current == null)
                        {
                            parent.left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if(current == null)
                        {
                            parent.right = newNode;
                            return;
                        }
                    }
                }
            }
            

        }

        public void searchNode(int data)
        {

        }

    }
}
