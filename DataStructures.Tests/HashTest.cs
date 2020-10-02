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

        [Fact]
        public void Add_adds_to_hash_table()
        {
            // Arrange
            HashTable<string> HT = new HashTable<string>();
            string value = "Hi";

            // Act
            HT.Add("1239", value);

            // Assert
            string expected = HT.HashFind("1239");
            Assert.Equal(expected, value);
        }



    }
}
