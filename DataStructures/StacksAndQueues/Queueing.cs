using System;
namespace DataStructures.StacksAndQueues
{
    public class Queue<T>
    {

        public class QNode
        {

            public QNode(T Qvalue)
            {
                QValue = Qvalue;
            }

            // Value of this node
            public T QValue { get; set; }

            // Pointer to the next node in the list
            public QNode QNext { get; set; }
        }

        public QNode QFront { get; set; }
        public QNode QRear { get; set; }

        public T QPeek()
        {
            return QFront.QValue;
        }

        public void Enqueue(T Qvalue)
        {
            QNode Qnode = new QNode(Qvalue);
            QRear.QNext = Qnode;
            QRear = Qnode;
        }


        public bool IsEmpty()
        {
            if (QFront == null)
            {
                return true;
            }

            else
                return false;
        }
    }
}
