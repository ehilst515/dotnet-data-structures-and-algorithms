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
        public void PreOrder_returns_values()
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

    }
}
