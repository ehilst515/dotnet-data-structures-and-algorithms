using DataStructures.LinkedLists;
using Xunit;

namespace DataStructures.Tests.LinkedLists
{
    public class LinkedListTests
    {
        [Fact]
        public void LinkedList_starts_empty()
        {
            // Act
            LinkedList list = new LinkedList();

            // Assert
            Assert.Equal("NULL", list.ToString());
        }

        [Fact]
        public void Insert_adds_value_to_start()
        {
            // Arrange
            LinkedList list = new LinkedList();

            // Act
            list.Insert(1);

            // Assert
            Assert.Equal("{ 1 } -> NULL", list.ToString());

            // Act
            list.Insert(2);

            // Assert
            Assert.Equal("{ 2 } -> { 1 } -> NULL", list.ToString());
        }

        [Fact]
        public void Includes_finds_items_in_nodes()
        {
            // Arrange
            LinkedList list = new LinkedList();

            // Act
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);

            // Assert
            bool expected = true;
            Assert.Equal(expected, list.Includes(2));
        }

        [Fact]
        public void Includes_does_not_cause_false_positives()
        {
            // Arrange
            LinkedList list = new LinkedList();

            // Act
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);

            // Assert
            bool expected = false;
            Assert.Equal(expected, list.Includes(5));
        }
    }
}