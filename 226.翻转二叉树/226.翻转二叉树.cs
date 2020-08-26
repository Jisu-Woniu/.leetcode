/*
 * @lc app=leetcode.cn id=226 lang=csharp
 *
 * [226] 翻转二叉树
 */

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
	public TreeNode InvertTree(TreeNode root)
	{
		if (root == null)
			return root;
		TreeNode temp = root.left;
		root.left = root.right;
		root.right = temp;
		if (root.left != null)
			InvertTree(root.left);
		if (root.right != null)
			InvertTree(root.right);
		return root;
	}
}
// @lc code=end