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
		Stack<TreeNode> stk = new Stack<TreeNode>();
		stk.Push(root);
		List<int> res = new List<int>();
		while (stk.Count > 0)
		{
			TreeNode current = stk.Pop();
			res.Add(current.val);
			if (current.right != null) stk.Push(current.right);
			if (current.left != null) stk.Push(current.left);
		}
		return res;
	}
}
// @lc code=end