using System;
using System.Text;
using System.Transactions;
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

    public class AnimalShelter
    {
        public class Node
        {
            public Node(Animal.Type value)
            {
                Value = value;
            }
            // Value of this node
            public Animal.Type Value { get; set; }
            // Pointer to the next node in the list
            public Node Next { get; set; }

            public Node Prev { get; set; }
        }

        public Node Front { get; set; }
        public Node Rear { get; set; }


        public void AnimalEnqueue(Animal.Type animal)
        {
            Node node = new Node(animal);
            if (Rear == null)
            {
                Front = Rear = node;

            }
            else
            {
                Node prev = Rear;
                Rear = node;
                prev.Next = node;
                node.Prev = prev;
            }
        }

        public Animal.Type? AnimalDequeue(Animal.Type pref)
        {
            var current = Front;
            if (pref == Animal.Type.Dog || pref == Animal.Type.Cat)
            {
                while (current != null)
                {
                    if(current.Value == pref)
                    {
                        Node temp = current;
                        current.Prev.Next = temp.Next;
                        current.Next.Prev = temp.Prev;
                        return current.Value;
                    }
                    current = current.Next;
                    if (current == Rear)
                        break;
                }
                return null;
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
