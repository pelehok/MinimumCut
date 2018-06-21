using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinimumCut.Models;
using MinimumCut.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumCut.Service.Tests
{
    [TestClass()]
    public class FileServiceTests
    {
        [TestMethod()]
        public void ReadVerticesTest()
        {
            List<AdjacencyList> adjacencyLists = FileService.ReadVertices();

            Assert.Fail();
        }
    }
}