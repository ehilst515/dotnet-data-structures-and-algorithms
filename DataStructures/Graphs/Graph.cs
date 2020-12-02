using DataStructures.Trees;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Graphs
{

    public class Graph<T>
    {
        public class Vertex
        {
            T Value { get; set; }

            public Vertex(T value)
            {
                Value = value;
                Neighbors = new LinkedList<Vertex>();
            }

            public LinkedList<Vertex> Neighbors { get; } = new LinkedList<Vertex>();
        }
        List<Vertex> Vertices { get; } = new List<Vertex>();


        public Vertex AddVertex(T value)
        {
            Vertex newVertex = new Vertex(value);
            Vertices.Add(newVertex);
            return newVertex;
        }

        public int Size()
        {
            return Vertices.Count;
        }

        public List<Vertex> GetVertices() 
        {
            return Vertices;
        }

        public void AddEdge(Vertex vertex1, Vertex vertex2)
        {
            vertex1.Neighbors.AddLast(vertex2);
            vertex2.Neighbors.AddLast(vertex1);
        }

        public IEnumerable<Vertex> GetNeighbors(Vertex vertex)
        {
            foreach (Vertex n in vertex.Neighbors)
                yield return n;
        }

        public IEnumerable<Vertex> BreadthFirst()
        {
            foreach (Vertex n in Vertices)
                yield return n;
        }

    }
}
