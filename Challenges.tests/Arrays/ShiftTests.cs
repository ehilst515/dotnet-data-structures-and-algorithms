using System;
using Challenges.Arrays;
using Xunit;


namespace Challenges.tests.Arrays
{
    public class ShiftTests
    {
        [Theory]
        //Challenge tests
        [InlineData(new[] { 2, 4, 6, 8 }, 5, new[] { 2, 4, 5, 6, 8 })]
        [InlineData(new[] { 4, 8, 15, 23, 42 }, 16, new[] { 4, 8, 15, 16, 23, 42 })]

        //Extra tests
        [InlineData(new[] { 1, 2, 4, 5 }, 3, new[] { 1, 2, 3, 4, 5 })]
        [InlineData(new[] { 10, 9, 8, 7, 6 }, 43 , new[] { 10, 9, 8, 43, 7, 6 })]
        [InlineData(new[] { 1}, 2, new[] { 1, 2})]
        [InlineData(new int[]  { }, 6, new[] {6})]

        public void insertShiftArray_adds_input_to_midpoint(int[] arrayToShift, int numberToInsert, int[] expected)
        {

            //Act
            int[] result = ArrayShift.insertShiftArray(arrayToShift, numberToInsert);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}