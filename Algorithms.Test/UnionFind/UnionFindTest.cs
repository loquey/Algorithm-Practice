using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Algorithms.UnionFind;

using Xunit;

namespace Algorithms.Test.UnionFind
{
    public class UnionFindTest
    {
        private QuickFind _Container { get; init; }

        public UnionFindTest()
        {
            _Container = new QuickFind(10);
        }

        [Fact]
        public void Should_Fail_When_CapacityMismatch()
        {
            var container = new QuickFind(10);

            Assert.Equal(10, container.Count);
        }

        [Fact]
        public void Should_Pass_When_Capacity_Match()
        {
            var container = new QuickFind(4);

            Assert.NotEqual(5, container.Count);
        }

        [Fact]
        public void Should_BeConnected_AfterUnion()
        {
            var container = new QuickFind(10);

            container.Union(4, 3);
            container.Union(4, 9);
            container.Union(6, 1);

            Assert.True(container.Connected(3, 9));
        }

        [Fact]
        public void Should_NotBeConnected_BeforeUnion()
        {
            var container = new QuickFind(10);

            container.Union(4, 3);
            container.Union(4, 9);
            container.Union(6, 1);

            Assert.False(container.Connected(4, 6));
        }
    }
}