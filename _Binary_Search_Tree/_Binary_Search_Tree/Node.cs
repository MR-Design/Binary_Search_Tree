using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Binary_Search_Tree
{
    class Node
    {
        public int data;
        public Node left;
        public Node right;

// Constractor...
        public Node(int Input)
        {
            data = Input;   // Constractor value when it's created
            left = null;    // New Value Will be Null when we create...
            right = null;   // ...the node, The Are Not Connected to anything.//

        }
    }
}
