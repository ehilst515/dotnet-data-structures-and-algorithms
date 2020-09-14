using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DataStructures.Trees
{
    class Tree
    {
        public Node Root { get; set; }
        public int[] PreOrder(Node node)
        {
            int[] result = new int[20];
            int i = 0;
            if(node != null)
            {
                result[i] = node.Value;
                i++;
                PreOrder(node.Left);
                PreOrder(node.Right);
            }

            return result;            
        }

        public int[] InOrder(Node node)
        {
            int[] result = new int[20];
            int i = 0;
            if (node != null)
            {
                PreOrder(node.Left);
                result[i] = node.Value;
                i++;
                PreOrder(node.Right);
            }

            return result;
        }

        public int[] PostOrder(Node node)
        {
            int[] result = new int[20];
            int i = 0;
            if (node != null)
            {
                PreOrder(node.Left);
                PreOrder(node.Right);
                result[i] = node.Value;
                i++;
            }

            return result;
        }
    }

 
}
