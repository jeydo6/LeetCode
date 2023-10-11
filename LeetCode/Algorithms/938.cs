using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _938
    {
        public class TreeNode
        {
            public TreeNode(Int32 x)
            {
                val = x;
            }

            public Int32 val;

            public TreeNode left;

            public TreeNode right;

        }

        public Int32 RangeSumBST(TreeNode root, Int32 L, Int32 R)
        {
            Int32 result = 0;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while(stack.Count > 0)
            {
                TreeNode node = stack.Pop();
                if (node != null)
                {
                    if (node.val >= L && node.val <= R)
                    {
                        result += node.val;
                    }

                    if (node.val > L)
                    {
                        stack.Push(node.left);
                    }

                    if (node.val < R)
                    {
                        stack.Push(node.right);
                    }
                }
            }

            return result;
        }

        //private int sum = 0;
        //public int RangeSumBST(TreeNode root, int L, int R)
        //{
        //    if (root != null)
        //    {
        //        RangeSumBST(root.left, L, R);
        //        sum += (root.val >= L && root.val <= R ? root.val : 0);
        //        RangeSumBST(root.right, L, R);
        //    }

        //    return sum;
        //}
    }
}
