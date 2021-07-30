using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _590
    {
        public class Node
        {
            public Node()
            {
                //
            }
            public Node(Int32 _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }

            public Int32 val;
            public IList<Node> children;
        }

        public IList<Int32> Postorder(Node root)
        {
            List<Int32> resultList = new List<Int32>();

            if (root == null)
            {
                return resultList;
            }

            Stack<Node> stack = new Stack<Node>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                Node current = stack.Pop();
                resultList.Add(current.val);

                if (current.children != null)
                {
                    foreach (Node children in current.children)
                    {
                        stack.Push(children);
                    }

                }

            }

            resultList.Reverse();

            return resultList;
        }

        public IList<Int32> Preorder(Node root)
        {
            List<Int32> resultList = new List<Int32>();

            if (root == null)
            {
                return resultList;
            }

            Stack<Node> stack = new Stack<Node>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                Node current = stack.Pop();
                resultList.Add(current.val);

                if (current.children != null)
                {
                    foreach (Node children in current.children.Reverse())
                    {
                        stack.Push(children);
                    }

                }

            }

            return resultList;
        }
    }
}
