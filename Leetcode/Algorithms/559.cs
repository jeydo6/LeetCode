using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _559
    {
        public class Node
        {
            public Int32 val;
            public IList<Node> children;

            public Node()
            {
                //
            }
            public Node(Int32 _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }

        public Int32 MaxDepth(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                Int32 depth = 0;
                if (root.children != null)
                {
                    foreach (Node child in root.children)
                    {
                        Int32 childDepth = MaxDepth(child);
                        depth = Math.Max(depth, childDepth);
                    }
                }
                return 1 + depth;
            }
        }
    }
}
