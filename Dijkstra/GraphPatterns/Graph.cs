using System;
using System.Collections.Generic;
using System.Text;

namespace Dijkstra.GraphPatterns
{
    class Graph
    {
        public List<GraphPoint> Points { get; } = new List<GraphPoint>();

        public void AddPoint(int pointVal)
        {
            Points.Add(new GraphPoint(pointVal));
        }

        public GraphPoint FindPoint(int pointValue)
        {
            foreach (var p in Points)
            {
                if (p.Value.Equals(pointValue))
                {
                    return p;
                }
            }

            return null;
        }

        public void AddEdge(int firstVal, int secondVal, int weight)
        {
            var p1 = FindPoint(firstVal);
            var p2 = FindPoint(secondVal);
            if (p2 != null && p1 != null)
            {
                p1.AddEdge(p2, weight);
                p2.AddEdge(p1, weight);
            }
        }
    }
}
