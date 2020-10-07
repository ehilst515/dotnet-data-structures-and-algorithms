using System;
using Xunit;
using DataStructures.HashTable;
using DataStructures.Trees;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;

namespace DataStructures.Tests
{
    public class HashTest
    {
        [Fact]
        public void GetHash_returns_hash_number()
        {
            // Arrange and Act
            int result = HashTable<ValueType>.GetHash("Hi");

            // Assert
            int expected = 1239;
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Hi", "1239")]
        [InlineData("Test", "1564")]
        [InlineData("Blue", "42")]
        public void Add_adds_to_hash_table(string value, string key)
        {
            // Arrange
            HashTable<string> HT = new HashTable<string>();

            // Act
            HT.Add(key, value);

            // Assert
            string expected = HT.HashFind(key);
            Assert.Equal(expected, value);
        }



        [Fact]
        public void TreeIntersect_returns_duplicate()
        {
            BinaryTree<int> tree1 = new BinaryTree<int>();
            BinaryTree<int> tree2 = new BinaryTree<int>();

            tree1.Root = new Node<int>(1);
            tree2.Root = new Node<int>(1);
            tree1.Root.Left = new Node<int>(2);
            tree2.Root.Left = new Node<int>(2);
            tree1.Root.Right = new Node<int>(3);
            tree2.Root.Right = new Node<int>(4);

            List<int> value = TreeIntersection<int>.TreeIntersect(tree1, tree2);

            List<int> expected = new List<int>();

            expected.Add(1);
            expected.Add(2);

            Assert.Equal(expected, value);
        }

        [Fact]
        public void TreeIntersect_returns_duplicate_challenge()
        {
            BinaryTree<int> tree1 = new BinaryTree<int>();
            BinaryTree<int> tree2 = new BinaryTree<int>();

            tree1.Root = new Node<int>(150);
            tree1.Root.Left = new Node<int>(100);
            tree1.Root.Left.Right = new Node<int>(160);
            tree1.Root.Left.Left = new Node<int>(125);
            tree1.Root.Left.Right.Right = new Node<int>(175);
            tree1.Root.Left.Left = new Node<int>(75);
            tree1.Root.Right = new Node<int>(250);
            tree1.Root.Right.Left = new Node<int>(200);
            tree1.Root.Right.Right = new Node<int>(350);
            tree1.Root.Right.Right.Right = new Node<int>(500);
            tree1.Root.Right.Right.Left = new Node<int>(300);

            tree2.Root = new Node<int>(42);
            tree2.Root.Left = new Node<int>(100);
            tree2.Root.Left.Right = new Node<int>(160);
            tree2.Root.Left.Left = new Node<int>(125);
            tree2.Root.Left.Right.Right = new Node<int>(175);
            tree2.Root.Left.Left = new Node<int>(15);
            tree2.Root.Right = new Node<int>(600);
            tree2.Root.Right.Left = new Node<int>(200);
            tree2.Root.Right.Right = new Node<int>(350);
            tree2.Root.Right.Right.Right = new Node<int>(500);
            tree2.Root.Right.Right.Left = new Node<int>(4);

            List<int> value = TreeIntersection<int>.TreeIntersect(tree1, tree2);

            List<int> expected = new List<int>();

            expected.Add(100);
            expected.Add(160);
            expected.Add(200);
            expected.Add(350);
            expected.Add(175);
            expected.Add(500);

            Assert.Equal(expected, value);
        }
    }
}
