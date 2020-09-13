using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{

        public class Node
        {
            public Node(int value)
            {
                Value = value;
            }
            // Value of this node
            public int Value { get; set; }
            // Pointer to the next node in the list
            public Node Left { get; set; }

            public Node Right { get; set; }
        }

}
