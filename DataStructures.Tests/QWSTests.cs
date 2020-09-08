using DataStructures.StacksAndQueues;
using Xunit;

namespace DataStructures.Tests
{
    public class QWSTests
    {
        [Fact]
        public void PsuedoQueue_starts_empty()
        {
            // Arrange and Act
            PsuedoQueue<int> psuedoQueue = new PsuedoQueue<int>();

            // Assert
            Assert.True(psuedoQueue.PQIsEmpty());

        }

        [Fact]
        public void PsuedoQueue_Enqueue_adds_to_PsuedoQueue()
        {
            // Arrange
            PsuedoQueue<int> psuedoQueue = new PsuedoQueue<int>();

            // Act
            psuedoQueue.Enqueue(1);

            // Assert
            Assert.False(psuedoQueue.PQIsEmpty());
        }

        [Fact]
        public void PsuedoQueue_Peek_returns_first_Enqueue_value()
        {
            // Arrange 
            PsuedoQueue<int> psuedoQueue = new PsuedoQueue<int>();
            psuedoQueue.Enqueue(1);
            psuedoQueue.Enqueue(2);
            psuedoQueue.Enqueue(3);

            // Act
            int result = psuedoQueue.Peek();

            // Assert
            int expected = 1;
            Assert.Equal(result, expected);


        }

        [Fact]
        public void PsuedoQueue_Denqueue_value()
        {
            // Arrange 
            PsuedoQueue<int> psuedoQueue = new PsuedoQueue<int>();
            psuedoQueue.Enqueue(1);
            psuedoQueue.Enqueue(2);
            psuedoQueue.Enqueue(3);

            // Act
            int result = psuedoQueue.Dequeue();


            // Assert
            int expected = 3;
            Assert.Equal(expected, result);
        }













    }
}
