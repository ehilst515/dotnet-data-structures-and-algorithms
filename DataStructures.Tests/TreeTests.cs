using Challenges.tests.Arrays;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DataStructures.Trees;
using System.Transactions;
using System.ComponentModel.Design.Serialization;
using System.Linq;

namespace DataStructures.Tests
{
    public class TreeTests
    {
        [Fact]
        public void Add_Binary_Tree_can_add_to_empty_tree()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();

            // Act
            tree.Add(1);

            //Assert
            Assert.Equal(1, tree.Root.Value);
        }

        [Fact]
        public void Add_can_add_single_Left_and_Right_nodes()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();

            // Act
            tree.Add(6);
            tree.Add(2);
            tree.Add(7);

            //Assert
            Assert.Equal(6, tree.Root.Value);
            Assert.Equal(2, tree.Root.Left.Value);
            Assert.Equal(7, tree.Root.Right.Value);
        }

        [Fact]
        public void Contains_can_find_Node_value()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Add(6);
            tree.Add(2);
            tree.Add(7); 
            tree.Add(3);
            tree.Add(10);
            tree.Add(1);

            // Act
            bool trueResult = tree.Contains(tree.Root, 10);
            bool falseResult = tree.Contains(tree.Root, 11);

            //Assert
            Assert.True(trueResult);
            Assert.False(falseResult);
        }

        [Fact]
        public void PreOrder_returns_values_as_strings()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Add(6);
            tree.Add(2);
            tree.Add(7);
            tree.Add(3);
            tree.Add(10);
            tree.Add(1);

            StringBuilder sb = new StringBuilder();

            // Act
            string result = tree.PreOrder(sb, tree.Root);

            //Assert
            Assert.Equal("6 2 1 3 7 10", result);
        }

        [Fact]
        public void InOrder_returns_values_as_strings()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Add(6);
            tree.Add(2);
            tree.Add(7);
            tree.Add(3);
            tree.Add(10);
            tree.Add(1);
            tree.Add(9);
            tree.Add(20);


            StringBuilder sb = new StringBuilder();
            sb.Append(" ");

            // Act
            string result = tree.InOrder(sb, tree.Root);

            //Assert
            Assert.Equal("1 2 3 6 7 9 10 20", result.Remove(0,1));
        }

        [Fact]
        public void PostOrder_returns_values_as_strings()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Add(6);
            tree.Add(2);
            tree.Add(7);
            tree.Add(3);
            tree.Add(10);
            tree.Add(1);
            tree.Add(9);
            tree.Add(20);


            StringBuilder sb = new StringBuilder();
            sb.Append(" ");

            // Act
            string result = tree.PostOrder(sb, tree.Root);

            //Assert
            Assert.Equal("1 3 2 9 20 10 7 6", result.Remove(0, 1));
        }
    }
}
