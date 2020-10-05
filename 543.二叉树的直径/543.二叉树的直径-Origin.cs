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
	int MaxDepth(TreeNode root)
	{
		if (root == null) return 0;
		else if (root.left == null && root.right == null) return 1;
		else if (root.left == null) return MaxDepth(root.right) + 1;
		else if (root.right == null) return MaxDepth(root.left) + 1;
		else return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
	}
	public int DiameterOfBinaryTree(TreeNode root)
	{
		if (root == null)
			return 0;
		return Math.Max(
			MaxDepth(root.left) + MaxDepth(root.right),
			Math.Max(DiameterOfBinaryTree(root.left), DiameterOfBinaryTree(root.right))
			);
	}
}
// @lc code=end