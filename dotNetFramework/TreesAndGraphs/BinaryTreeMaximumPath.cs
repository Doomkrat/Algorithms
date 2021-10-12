using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetFramework.TreesAndGraphs
{
    public class BinaryTreeMaximumPath
    {
        //public int max_path_sum;
        //public int MaxPathSum(TreeNode root)
        //{
        //    max_path_sum = Int32.MinValue;
        //    pathSum(root);
        //    return max_path_sum;
        //}

        //public int pathSum(TreeNode node)
        //{
        //    if (node == null) return 0;

        //    int left = Math.Max(0, pathSum(node.FirstNode));
        //    int right = Math.Max(0, pathSum(node.LastNode));

        //    return Math.Max(left, right) + pathSum(node.Parent);
        //}

        //public int MaxPathSum(TreeNode root)
        //{
        //    Aux result = helper(root);
        //    return Math.Max(result.maxWithRoot, Math.Max(result.maxWithoutRoot, result.maxOnePath));
        //}

        //public class Aux
        //{
        //    public int maxWithRoot;
        //    public int maxWithoutRoot;
        //    public int maxOnePath;

        //    public Aux(int a, int b, int c)
        //    {
        //        maxWithRoot = a;
        //        maxWithoutRoot = b;
        //        maxOnePath = c;
        //    }
        //}

        //public Aux helper(TreeNode node)
        //{
        //    if (node == null) return new Aux(Int32.MinValue, Int32.MinValue, Int32.MinValue);

        //    Aux left = helper(node.left);
        //    Aux right = helper(node.right);

        //    int maxWithRoot = Math.Max(0, left.maxOnePath) + Math.Max(0, right.maxOnePath) + node.val;

        //    int maxLeft = Math.Max(Math.Max(left.maxWithRoot, left.maxWithoutRoot), left.maxOnePath);
        //    int maxRight = Math.Max(Math.Max(right.maxWithRoot, right.maxWithoutRoot), right.maxOnePath);

        //    int maxWithoutRoot = Math.Max(maxLeft, maxRight);

        //    int maxOnePath = Math.Max(Math.Max(left.maxOnePath, right.maxOnePath), 0) + node.val;

        //    Aux result = new Aux(maxWithRoot, maxWithoutRoot, maxOnePath);
        //    return result;
        //}
    }
}
