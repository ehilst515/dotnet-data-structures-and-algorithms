using System;
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

        [Fact]
        public void Append_adds_node_to_end_of_ll()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(3);
            list.Insert(2);
            list.Insert(1);

            // Act
            list.Append(4);


            // Assert
            Assert.Equal("{ 1 } -> { 2 } -> { 3 } -> { 4 } -> NULL", list.ToString());
        }

        [Fact]
        public void Append_adds_node_to_empty_ll()
        {
            // Arrange
            LinkedList list = new LinkedList();

            //// Act
            list.Append(4);


            // Assert
            Assert.Equal("{ 4 } -> NULL", list.ToString());
        }

        [Fact]
        public void InsertBefore_inserts_before_specified_node()
        {

            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(3);
            list.Insert(2);
            list.Insert(1);

            //Act
            list.InsertBefore(2, 5);

            // Assert
            Assert.Equal("{ 1 } -> { 5 } -> { 2 } -> { 3 } -> NULL", list.ToString());
        }

        [Fact]
        public void InsertAfter_inserts_after_specified_node()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(3);
            list.Insert(2);
            list.Insert(1);

            //Act
            list.InsertAfter(2, 5);

            // Assert
            Assert.Equal("{ 1 } -> { 2 } -> { 5 } -> { 3 } -> NULL", list.ToString());
        }
        [Fact]
        public void Search_at_kValue_from_end()
        {
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.Insert(7);
            list.Insert(8);
            list.Insert(9);
            int result = list.KthFromEnd(4);
            Assert.Equal(4, result);
        }
        [Fact]
        public void Search_at_kValue_if_empty_list()
        {
            LinkedList list = new LinkedList();
            Assert.Throws<NullReferenceException>(() =>
            {
                //Act
                return list.KthFromEnd(3);
            });
        }
        [Fact]
        public void Search_list_with_one_node()
        {
            LinkedList list = new LinkedList();
            list.Insert(1);
            Assert.Throws<NullReferenceException>(() =>
            {
                //Act
                return list.KthFromEnd(3);
            });
        }
    }
}