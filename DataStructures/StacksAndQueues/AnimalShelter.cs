using System;
using System.Text;
using DataStructures.StacksAndQueues;

namespace DataStructures.StacksAndQueues
{
    public class Animal
    {
        public enum Type { 
            Dog,
            Cat,
            Bird
        }
    }

    public class AnimalShelter<T>
    {
        public class Node
        {
            public Node(T value)
            {
                Value = value;
            }
            // Value of this node
            public T Value { get; set; }
            // Pointer to the next node in the list
            public Node Next { get; set; }

            public Node Prev { get; set; }
        }
        public Node Front { get; set; }
        public Node Rear { get; set; }


        public void AnimalEnqueue(T animal)
        {
            Node node = new Node(animal);
            if (Front == null)
            {
                node.Next = node;
                Front = node;
            }

            else
            {
                node.Next = node;
                Rear = node;
            }
        }

        public Node AnimalDequeue(Animal.Type pref)
        {
            if (pref == Animal.Type.Dog || pref == Animal.Type.Dog)
            {
                Node temp = Front;
                Front = Front.Next;
                temp.Next = null;
                return temp;
            }
            
            else return null;
        }

        public bool ShelterIsEmpty()
        {
            if (Front == null)
            {
                return true;
            }
            else
                return false;
        }




    }
}
