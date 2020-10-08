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
            // Arrange
            BinaryTree<int> tree1 = new BinaryTree<int>();
            BinaryTree<int> tree2 = new BinaryTree<int>();

            tree1.Root = new Node<int>(1);
            tree2.Root = new Node<int>(1);
            tree1.Root.Left = new Node<int>(2);
            tree2.Root.Left = new Node<int>(2);
            tree1.Root.Right = new Node<int>(3);
            tree2.Root.Right = new Node<int>(4);

            // Act
            List<int> value = TreeIntersection<int>.TreeIntersect(tree1, tree2);

            // Assert
            List<int> expected = new List<int>();

            expected.Add(1);
            expected.Add(2);

            Assert.Equal(expected, value);
        }

        [Fact]
        public void TreeIntersect_returns_duplicate_challenge()
        {
            // Arrange
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

            // Act
            List<int> value = TreeIntersection<int>.TreeIntersect(tree1, tree2);

            // Assert
            List<int> expected = new List<int>();

            expected.Add(100);
            expected.Add(160);
            expected.Add(200);
            expected.Add(350);
            expected.Add(175);
            expected.Add(500);

            Assert.Equal(expected, value);
        }

        [Fact]
        public void LeftJoin_can_left_join_single_key_value_pairs()
        {
            // Arrange
            LeftJoin leftJoin = new LeftJoin();
            Dictionary<string, string> HT1 = new Dictionary<string, string>();
            Dictionary<string, string> HT2 = new Dictionary<string, string>();

            HT1.Add("key", "value1");
            HT2.Add("key", "value2");

            // Act
            List<string[]> result = leftJoin.LeftJoiner(HT1, HT2);

            // Assert
            List<string[]> expected = new List<string[]>();
            string[] expectedArray = new string[3] {"key", "value1", "value2" };
            expected.Add(expectedArray);

            Assert.Equal(expected, result);

        }

        [Fact]
        public void LeftJoin_can_left_join()
        {
            // Arrange
            LeftJoin leftJoin = new LeftJoin();
            Dictionary<string, string> HT1 = new Dictionary<string, string>();
            Dictionary<string, string> HT2 = new Dictionary<string, string>();

            HT1.Add("fond", "enamored");
            HT1.Add("wrath", "anger");
            HT1.Add("diligent", "employed");
            HT1.Add("outfit", "garb");
            HT1.Add("guide", "usher");

            HT2.Add("fond", "averse");
            HT2.Add("wrath", "delight");
            HT2.Add("diligent", "idle");
            HT2.Add("guide", "follow");
            HT2.Add("flow", "jam"); //<- Not expected to be in result

            // Act
            List<string[]> result = leftJoin.LeftJoiner(HT1, HT2);

            // Assert
            // Expected: [["fond", "enamored", "averse"], ["wrath", "anger", "delight"], ["diligent", "employed", "idle"], ["outfit", "garb", null], ["guide", "usher", "follow"] , ["flow", null, "jam"]]
            List<string[]> expected = new List<string[]>();
            string[] expectedArray1 = new string[3] { "fond", "enamored", "averse" };
            string[] expectedArray2 = new string[3] { "wrath", "anger", "delight" };
            string[] expectedArray3 = new string[3] { "diligent", "employed", "idle" };
            string[] expectedArray4 = new string[3] { "outfit", "garb", null };
            string[] expectedArray5 = new string[3] { "guide", "usher", "follow" };

            expected.Add(expectedArray1);
            expected.Add(expectedArray2);
            expected.Add(expectedArray3);
            expected.Add(expectedArray4);
            expected.Add(expectedArray5);

            Assert.Equal(expected, result);
        }
    }
}