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
            int result = HashTable.HashTable<ValueType>.GetHash("Hi");

            // Assert
            int expected = 1239;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_adds_to_hash_table()
        {
            // Arrange
            LinkedList<string>[] HT = new LinkedList<string>[10];
            string value = "Hi";

            // Act
            HashTable<string>.Add("1239", value , HT);

            // Assert
            string expected = HashTable<string>.HashFind("1239", HT);
            Assert.Equal(expected, value);
        }



    }
}
