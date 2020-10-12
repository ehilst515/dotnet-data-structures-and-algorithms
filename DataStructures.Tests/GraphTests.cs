using Xunit;
using DataStructures.Graphs;
using System.Linq;
using static DataStructures.Graphs.Graph<int>;

namespace DataStructures.Tests
{
    public class GraphTests
    {
        [Fact]
        public void AddVertex_can_add() 
        {
            // Arrange
            Graph<int> graph = new Graph<int>();

            // Act
            var vertex1 = graph.AddVertex(1);
            var vertex2 = graph.AddVertex(2);
            graph.AddEdge(vertex1, vertex2);

            // Assert
            Assert.Contains(vertex2, graph.GetNeighbors(vertex1));
        }

    }
}
