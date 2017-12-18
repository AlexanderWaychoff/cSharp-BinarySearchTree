using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample
{
    public class Node
    {
        public int? data = null;  //should have a getter/setter but we're being lazy
        public Node left;
        public Node right;

        public Node()
        {
            this.data = null;
        }
        public Node(int item) //overloading constructor
        {
            this.data = item;
        }
    }
}
