/*
 * @lc app=leetcode.cn id=94 lang=csharp
 *
 * [94] 二叉树的中序遍历
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
	public IList<int> InorderTraversal(TreeNode root)
	{
		if (root == null) return new List<int>();
		List<int> res = new List<int>();
		if (root.left != null) res.AddRange(InorderTraversal(root.left));
		res.Add(root.val);
		if (root.right != null) res.AddRange(InorderTraversal(root.right));
		return res;
	}
}
// @lc code=end