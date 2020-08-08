/*
 * @lc app=leetcode.cn id=110 lang=csharp
 *
 * [110] 平衡二叉树
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
	public bool IsBalanced(TreeNode root)
	{
		if (root == null) return true;
		else if (root.left == null && root.right == null)
		{
			root.val = 1;
			return true;
		}
		else if (IsBalanced(root.left) && IsBalanced(root.right))
		{
			if (root.left == null) root.left = new TreeNode(0);
			else if (root.right == null) root.right = new TreeNode(0);
			root.val = Math.Max(root.left.val, root.right.val) + 1;
			return Math.Abs(root.left.val - root.right.val) <= 1;
		}
		else return false;
	}
}
// @lc code=end