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
                throw new Exception("Does not exist");
            }

            Vertices.Add(vertex);
        }

        bool RemoveVertex(Vertex<T> vertex)
        {
            if (!(Vertices.Contains(vertex)))
            {
                return false;
            }

            for (int i = 0; i < vertex.Neighbors.Count; i++)
            {
                RemoveEdge(vertex, vertex.Neighbors[i]);
            }

            return Vertices.Remove(vertex);
        }

        bool RemoveEdge(Vertex<T> a, Vertex<T> b)
        {
            if (a == null)
            {
                throw new Exception(" ");
            }

            if (b == null)
            {
                throw new Exception(" ");
            }

            if (!(Vertices.Contains(a) && Vertices.Contains(b) && a.Neighbors.Contains(b)))
            {

                return false;
            }

            a.Neighbors.Remove(b);
            b.Neighbors.Remove(a);

            return true;

        }

        bool AddEdge(Vertex<T> a, Vertex<T> b)
        {
            if (a == null)
            {
                throw new Exception(" ");
            }
            if (b == null)
            {
                throw new Exception(" ");
            }

            if (!(Vertices.Contains(a) && Vertices.Contains(b)))
            {
                return false;
            }

            a.Neighbors.Add(b);
            b.Neighbors.Add(a);

            return true;
        }

        Vertex<T> Search(T value)
        {
            int index = -1;

            for (int i = 0; i < Vertices.Count; i++)
            {
                if(value.Equals(Vertices[i].value))
                {
                    index = i;
                    return Vertices[i];
                    
                    
                }
            }

            return null;

            
        }

        List<T> DepthFirstTraversal()
        {
            //Stack or Recursion

            List<T> list = new List<T>();
            for (int i = 0; i < Vertices.Count; i++)
            {
                if(list.Contains(Vertices[i].value) == true)
                {
                    i++;
                }

                list.Add(Vertices[i].value);
            }

            return list;
        }



    }
}
