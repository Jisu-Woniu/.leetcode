/*
 * @lc app=leetcode.cn id=404 lang=csharp
 *
 * [404] 左叶子之和
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
	public int SumOfLeftLeaves(TreeNode root)
	{
		if (root == null)
			return 0;
		TreeNode l = root.left;
		int s = 0;
		if (l != null && l.left == null && l.right == null)
			s += l.val;
		else
			s += SumOfLeftLeaves(l);
		s += SumOfLeftLeaves(root.right);
		return s;
	}
}
// @lc code=end