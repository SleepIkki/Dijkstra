using System;
using System.Collections.Generic;
using System.Text;
using Dijkstra.GraphPatterns;

namespace Dijkstra
{
    class Dijkstra
    {
        Graph graph;

        List<GraphPointInfo> data;

        public Dijkstra(Graph graph)
        {
            this.graph = graph;
        }

        void InitData()
        {
            data = new List<GraphPointInfo>();
            foreach (var p in graph.Points)
            {
                data.Add(new GraphPointInfo(p));
            }
        }

        GraphPointInfo GetPointData(GraphPoint point)
        {
            foreach (var i in data)
            {
                if (i.Point.Equals(point))
                {
                    return i;
                }
            }

            return null;
        }

        public GraphPointInfo FindUnvisitedPointWithMinSum()
        {
            var minValue = int.MaxValue;
            GraphPointInfo minPointInfo = null;
            foreach (var d in data)
            {
                if (d.IsUnvisited && d.EdgesWeightSum < minValue)
                {
                    minPointInfo = d;
                    minValue = d.EdgesWeightSum;
                }
            }

            return minPointInfo;
        }

        public string FindShortestPath(int startValue, int finishValue)
        {
            return FindShortestPath(graph.FindPoint(startValue), graph.FindPoint(finishValue));
        }

        public string FindShortestPath(GraphPoint startPoint, GraphPoint finishPoint)
        {
            InitData();
            var first = GetPointData(startPoint);
            first.EdgesWeightSum = 0;
            while (true)
            {
                var current = FindUnvisitedPointWithMinSum();
                if (current == null)
                {
                    break;
                }

                SetSumToNextPoint(current);
            }

            return GetPath(startPoint, finishPoint);
        }

        void SetSumToNextPoint(GraphPointInfo info)
        {
            info.IsUnvisited = false;
            foreach (var e in info.Point.Edges)
            {
                var nextInfo = GetPointData(e.ConnectedPoint);
                var sum = info.EdgesWeightSum + e.EdgeWeight;
                if (sum < nextInfo.EdgesWeightSum)
                {
                    nextInfo.EdgesWeightSum = sum;
                    nextInfo.PreviousPoint = info.Point;
                }
            }
        }

        string GetPath(GraphPoint startPoint, GraphPoint endPoint)
        {
            var path = endPoint.ToString();
            while (startPoint != endPoint)
            {
                endPoint = GetPointData(endPoint).PreviousPoint;
                path = endPoint.ToString() + path;
            }

            return path;
        }
    }
}
