using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DataStructures.HashTable;
using System.Linq;

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



    }
}
