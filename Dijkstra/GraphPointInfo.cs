using System;
using System.Collections.Generic;
using System.Text;
using Dijkstra.GraphPatterns;

namespace Dijkstra
{
    class GraphPointInfo
    {
        public GraphPoint Point { get; set; }
        public bool IsUnvisited { get; set; }
        public int EdgesWeightSum { get; set; }
        public GraphPoint PreviousPoint { get; set; }

        public GraphPointInfo(GraphPoint point)
        {
            Point = point;
            IsUnvisited = true;
            EdgesWeightSum = int.MaxValue;
            PreviousPoint = null;
        }
    }
}
