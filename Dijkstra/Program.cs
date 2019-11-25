using System;
using Dijkstra.GraphPatterns;

namespace Dijkstra
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph();

            g.AddPoint(1);
            g.AddPoint(2);
            g.AddPoint(3);
            g.AddPoint(4);
            g.AddPoint(5);
            g.AddPoint(6);
            g.AddPoint(7);
            g.AddPoint(8);

            g.AddEdge(1, 3, 6);
            g.AddEdge(1, 6, 8);
            g.AddEdge(1, 4, 7);
            g.AddEdge(2, 3, 1);
            g.AddEdge(2, 4, 3);
            g.AddEdge(2, 7, 4);
            g.AddEdge(3, 8, 7);
            g.AddEdge(4, 5, 9);
            g.AddEdge(5, 7, 5);
            g.AddEdge(6, 8, 3);
            g.AddEdge(7, 8, 4);

            var dijkstra = new Dijkstra(g);
            var path = dijkstra.FindShortestPath(1, 7);

            Console.WriteLine(path);
            Console.ReadLine();
        }
    }
}
