using System;
using System.Collections.Generic;
using System.Text;

namespace Dijkstra.Graph
{
    class GraphEdge
    {
        public GraphPoint ConnectedPoint { get; }
        public int EdgeWeight { get; }
        public GraphEdge(GraphPoint connectedPoint, int weight)
        {
            ConnectedPoint = connectedPoint;
            EdgeWeight = weight;
        }
    }
}
