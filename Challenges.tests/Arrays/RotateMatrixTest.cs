using Challenges.Arrays;
using Xunit;

namespace Challenges.tests.Arrays
{
    public class RotateMatrixTest
    {
        [Fact]
        public void RotateMatrix_Rotates_Matrix()
        {
            //Arrange
            int[][] matrix = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };

            //Act
            var actual = RotateMatrix.MatrixRotate(matrix);

            //Assert
            var expected = new int[][] { new int[] { 7, 4, 1 }, new int[] { 8, 5, 2 }, new int[] { 9, 6, 3 } };

            Assert.Equal(expected, actual);
        }
    }
}
