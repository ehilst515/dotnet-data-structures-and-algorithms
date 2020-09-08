using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.StacksAndQueues
{
    public class PsuedoQueue<T>
    {
        private Stack<T> stack1 = new Stack<T>();
        private Stack<T> stack2 = new Stack<T>();

        public T Dequeue()
        {
            if(stack1.IsEmpty())
                throw new InvalidOperationException();

            while (stack1.IsEmpty() == false)
                stack2.Push(stack1.Pop());

            T result = stack2.Pop();

            while (stack2.IsEmpty() == false)
                stack1.Push(stack2.Pop());

            return result;
        }

        public void Enqueue(T value)
        {
            while (stack1.IsEmpty() == false)
                stack2.Push(stack1.Pop());

            stack1.Push(value);

            while (stack2.IsEmpty() == false)
                stack1.Push(stack2.Pop());
        }

        public T Peek()
        {
            return stack1.Peek();
        }

        public bool PQIsEmpty()
        {
            if (stack1.IsEmpty())
                return true;
            else
                return false;
        }

        //public string PQToString()
        //{
        //    Node current = stack1.Top;
        //    string result = "";
        //    while (current != null)
        //    {
        //        result += $"{{ {current.Value} }} -> ";
        //        current = current.Next;
        //    }
        //    return result + "NULL";
        //}

    }
}
