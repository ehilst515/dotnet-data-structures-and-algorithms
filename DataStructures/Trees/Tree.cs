using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DataStructures.Trees
{
    class Tree
    {
        public Node Root { get; set; }
        public int[] PreOreder(Node node)
        {
            int[] result = new int[20];
            int i = 0;
            if(node != null)
            {
                result[i] = node.Value;
                i++;
                PreOreder(node.Left);
                PreOreder(node.Right);
            }

            return result;            
        }

        public int[] InOreder(Node node)
        {
            int[] result = new int[20];
            int i = 0;
            if (node != null)
            {
                PreOreder(node.Left);
                result[i] = node.Value;
                i++;
                PreOreder(node.Right);
            }

            return result;
        }

        public int[] PostOreder(Node node)
        {
            int[] result = new int[20];
            int i = 0;
            if (node != null)
            {
                PreOreder(node.Left);
                PreOreder(node.Right);
                result[i] = node.Value;
                i++;
            }

            return result;
        }
    }

 
}
