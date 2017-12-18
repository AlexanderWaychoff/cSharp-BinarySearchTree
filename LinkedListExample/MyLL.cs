using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample
{
    class MyLL
    {
        Node head = null;
        int count;
        string directions = "base";

        public MyLL()
        {

        }
        public void Add()   //int item
        {
            Console.WriteLine("Enter a Integer to add.");
            Node node = new Node(Convert.ToInt32(Console.ReadLine()));
            if (head == null)
            {
                head = node;
                return; //can be used to kill the function
            }
            Node current = head;
            while (current != null)
            {
                if (node.data > current.data)
                {
                    if (current.right == null)
                    {
                        current.right = node;
                        return;
                    }
                    else if (current.right.data == node.data)
                    {
                        Console.WriteLine("Node already contains this number.");
                        return; //trying to add a duplicate
                    }
                    current = current.right;
                }
                else if(node.data < current.data)
                {
                    if (current.left == null)
                    {
                        current.left = node;
                        return;
                    }
                    else if (current.left.data == node.data)
                    {
                        Console.WriteLine("Node already contains this number.");
                        return; //trying to add a duplicate
                    }
                    current = current.left;
                }
                else
                {
                    Console.WriteLine("Node already contains this number.");
                    return;
                }
            }
            Console.WriteLine("Node already contains this number.");
        }
        public bool Search(int searchData)
        {
            bool itemFound = false;
            Node current = head;
            while(current != null)
            {
                if (current.right != null && searchData > current.data)
                {
                    current = current.right;
                    directions += " + right";
                }
                else if (current.left != null && searchData < current.data)
                {
                    current = current.left;
                    directions += " + left";
                }
                else if (searchData == current.data)
                {
                    Console.WriteLine("Found " + searchData + " by going " + directions);
                    directions = "base";
                    return true;
                }
                else
                {
                    Console.WriteLine("Number not found.");
                    return false;
                }
            }
            return false;
        }

        //create a binary search tree using linked lists
    }
}
