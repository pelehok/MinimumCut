using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumCut.Models
{
    public class AdjacencyList
    {
        public Vertex Vertex { get; set; }
        public List<Vertex> adjacencyList { get; set; }
    }
}
