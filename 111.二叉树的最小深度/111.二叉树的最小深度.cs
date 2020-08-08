/*
 * @lc app=leetcode.cn id=111 lang=csharp
 *
 * [111] 二叉树的最小深度
 */
using System.Collections.Generic;
// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution
{
	public int MinDepth(TreeNode root)
	{
		if (root == null) return 0;
		root.val = 1;
		Queue<TreeNode> nodes = new Queue<TreeNode>();
		nodes.Enqueue(root);
		while(nodes.Count>0)
		{
			TreeNode n = nodes.Dequeue();
			if (n.left == null && n.right == null) return n.val;
			if(n.left!=null)
			{
				n.left.val = n.val + 1;
				nodes.Enqueue(n.left);
			}
			if(n.right!=null)
			{
				n.right.val = n.val + 1;
				nodes.Enqueue(n.right);
			}
		}
		return -1;
	}
}
// @lc code=end