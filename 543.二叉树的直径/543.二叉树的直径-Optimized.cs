/*
 * @lc app=leetcode.cn id=543 lang=csharp
 *
 * [543] 二叉树的直径
 */
using System;
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
	int d;
	int depth(TreeNode node)
	{
		if (node == null)
			return 0;
		int l = depth(node.left);
		int r = depth(node.right);
		d = Math.Max(d, l + r + 1);
		return Math.Max(l, r) + 1;
	}
	public int DiameterOfBinaryTree(TreeNode root)
	{
		if (root == null)
			return 0;
		d = 1;
		depth(root);
		return d - 1;
	}
}
// @lc code=end