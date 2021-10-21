using System;
using System.Collections.Generic;
using System.Text;

namespace Unweighted_and_Undirected_Graphs
{
    class Vertex<T>
    {
        public T value { get; set; }
        public List<Vertex<T>> Neighbors { get; set; }

        public int NeighborCount => Neighbors.Count;

        public Vertex(T value) 
        {
            Neighbors = new List<Vertex<T>>();
        }
    }
}
