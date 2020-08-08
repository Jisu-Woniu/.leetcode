/*
 * @lc app=leetcode.cn id=144 lang=csharp
 *
 * [144] 二叉树的前序遍历
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
	public IList<int> PreorderTraversal(TreeNode root)
	{
		if (root == null) return new List<int>();
		List<int> res = new List<int>() { root.val };
		if (root.left != null) res.AddRange(PreorderTraversal(root.left));
		if (root.right != null) res.AddRange(PreorderTraversal(root.right));
		return res;
	}
}
// @lc code=end