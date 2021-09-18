using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.UnionFind
{
    public class QuickFind
    {
        public int Count => _Capacity;

        /// <summary>
        /// Initiate container
        /// </summary>
        /// <param name="capacity"></param>
        public QuickFind(int capacity)
        {
            _Capacity = capacity;
            _Nodes = new int[capacity];
        }

        /// <summary>
        /// Connect rhs and lhs
        /// </summary>
        /// <param name="rhs"></param>
        /// <param name="lhs"></param>
        public void Union(int rhs, int lhs)
        {
        }

        /// <summary>
        /// Check if the lhs is connected to rhs
        /// </summary>
        /// <param name="rhs"></param>
        /// <param name="lhs"></param>
        /// <returns></returns>
        public bool Connected(int rhs, int lhs)
        {
            return false;
        }

        public int find(int p)
        {
            return -1;
        }

        private int _Capacity;
        private int[] _Nodes;
    }
}