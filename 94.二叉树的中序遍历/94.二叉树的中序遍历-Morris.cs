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
		List<int> r = new List<int>();
		while (root != null)
		{
			if (root.left == null)
			{
				r.Add(root.val);
				root = root.right;
			}
			else
			{
				TreeNode pre = root.left;
				while (pre.right != null && pre.right != root)
				{
					pre = pre.right;
				}
				if (pre.right == null)
				{
					pre.right = root;
					root = root.left;
				}
				else
				{
					r.Add(root.val);
					root.left = null;
					root = root.right;
				}
			}
		}
		return r;
	}
}
// @lc code=end