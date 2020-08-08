/*
 * @lc app=leetcode.cn id=104 lang=csharp
 *
 * [104] 二叉树的最大深度
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
	public int MaxDepth(TreeNode root)
	{
		if (root == null) return 0;
		else if (root.left == null && root.right == null) return 1;
		else if (root.left == null) return MaxDepth(root.right) + 1;
		else if (root.right == null) return MaxDepth(root.left) + 1;
		else return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
	}
}
// @lc code=end