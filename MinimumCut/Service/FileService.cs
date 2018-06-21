using MinimumCut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumCut.Service
{
    public class FileService
    {
        private static string FileName = @"C:/Vertices.txt";
        public static List<AdjacencyList> ReadVertices()
        {
            string[] lines = System.IO.File.ReadAllLines(FileName);

            List<AdjacencyList> adjacencyLists = new List<AdjacencyList>();
            
            for (int i = 0; i < lines.Length; i++)
            {
                List<string> adjacencyVertices = lines[i].Split('\t').ToList();
                int mainVertex = Convert.ToInt32(adjacencyVertices[0]);
                adjacencyVertices.RemoveAt(0);
                adjacencyVertices.RemoveAt(adjacencyVertices.Count-1);
                List<Vertex> verticeList = new List<Vertex>();
                adjacencyVertices.ToList().ForEach((x) => { verticeList.Add(new Vertex() { Number = Convert.ToInt32(x) }); });
                adjacencyLists.Add(new AdjacencyList() { Vertex = new Vertex() { Number = mainVertex }, adjacencyList = verticeList });
            }
            return adjacencyLists;
        }
    }
}
