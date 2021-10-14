using System;
using System.Collections.Generic;
using System.Text;

namespace Unweighted_and_Undirected_Graphs
{
    class Graph<T>
    {
        public List<Vertex<T>> Vertices { get; private set; }

        public int VertexCount => Vertices.Count;

        public Graph()
        {
            Vertices = new List<Vertex<T>>();
        }

        //.neightbors.add
        void AddVertex(Vertex<T> vertex)
        {
            if (vertex == null)
            {
                throw new ArgumentNullException(nameof(vertex));
            }
            else if (vertex.Neighbors.Count != 0 || Vertices.Contains(vertex))
            {
                throw new
            }
        }
    }
}
