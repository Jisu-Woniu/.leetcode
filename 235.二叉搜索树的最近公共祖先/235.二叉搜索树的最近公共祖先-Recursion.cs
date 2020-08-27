/*
 * @lc app=leetcode.cn id=235 lang=csharp
 *
 * [235] 二叉搜索树的最近公共祖先
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
	public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
	{
		if (p.val == root.val || q.val == root.val || (p.val < root.val) == (q.val > root.val))
			return root;
		else if (p.val < root.val && q.val < root.val)
			return LowestCommonAncestor(root.left, p, q);
		else
			return LowestCommonAncestor(root.right, p, q);
	}
}
// @lc code=end