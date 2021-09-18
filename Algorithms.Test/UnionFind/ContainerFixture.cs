using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Algorithms.UnionFind;

namespace Algorithms.Test.UnionFind
{
    public class ContainerFixture
    {
        public QuickFind Container { get; init; }

        public ContainerFixture()
        {
            Container = new QuickFind(10);
        }
    }
}