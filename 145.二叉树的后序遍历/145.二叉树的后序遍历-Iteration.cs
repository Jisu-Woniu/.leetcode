/*
 * @lc app=leetcode.cn id=145 lang=csharp
 *
 * [145] 二叉树的后序遍历
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
	public IList<int> PostorderTraversal(TreeNode root)
	{
		if (root == null) return new List<int>();
		Stack<TreeNode> stk = new Stack<TreeNode>();
		stk.Push(root);
		List<int> res = new List<int>();
		while (stk.Count > 0)
		{
			TreeNode current = stk.Pop();
			res.Add(current.val);
			if (current.left != null) stk.Push(current.left);
			if (current.right != null) stk.Push(current.right);
		}
		res.Reverse();
		return res;
	}
}
// @lc code=end