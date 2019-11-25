using System;
using System.Collections.Generic;
using System.Text;

namespace Dijkstra.Graph
{
    class GraphPoint
    {
        public int Value { get; }
        public List<GraphEdge> Edges { get; }

        public GraphPoint(int value)
        {
            Value = value;
            Edges = new List<GraphEdge>();
        }

        public void AddEdge(GraphEdge edge) => Edges.Add(edge);

        public void AddEdge(GraphPoint point, int edgeWeight)
        {
            AddEdge(new GraphEdge(point, edgeWeight));
        }

        public override string ToString() => Value.ToString();
    }
}
