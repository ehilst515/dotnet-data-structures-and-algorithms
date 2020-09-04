using System;
using DataStructures.StacksAndQueues;
using Xunit;


namespace DataStructures.Tests
{
    public class SandQTests
    {
        [Fact]
        public void IsEmpty_returns_true_if_stack_is_empty()
        {
            // Arrange 
             Stack<int> stack = new Stack<int>();

            // Act
            bool result = stack.IsEmpty();

            // Assert
            Assert.True(result);

        }

        [Fact]
        public void IsEmpty_returns_false_if_stack_is_not_empty()
        {
            // Arrange 
            Stack<int> stack = new Stack<int>();
            stack.Push(1);

            // Act
            bool result = stack.IsEmpty();

            // Assert
            Assert.False(result);

        }

        [Fact]
        public void Push_adds_to_stack()
        {
            // Arrange
            Stack<int> stack = new Stack<int>();

            // Act
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);

            // Assert
            Assert.Equal(1, stack.Peek());
        }

        [Fact]
        public void Pop_removes_top_of_stack_and_returns_value()
        {
            // Arrange
            Stack<int> stack = new Stack<int>();
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);

            //Act
            int result = stack.Pop();

            //Assert
            Assert.Equal(2, stack.Peek());
            Assert.Equal(1, result);
        }

        [Fact]
        public void Pop_can_empty_stack()
        {
            // Arrange
            Stack<int> stack = new Stack<int>();
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);

            //Act
            stack.Pop();
            stack.Pop();
            stack.Pop();

            //Assert
            Assert.True(stack.IsEmpty());
        }

    //Queue Tests

        //[Fact]
        //public void Enqueue_adds_node_to_rear()
        //{
        //    // Arrange
        //    Queue<int> queue = new Queue<int>();

        //    // Act
        //    queue.Enqueue(1);
        //    queue.Enqueue(1);

        //    //Assert
        //    Assert.Equal(1, queue.QPeek());

        //}
    }

}
