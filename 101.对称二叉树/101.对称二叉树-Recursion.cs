/*
 * @lc app=leetcode.cn id=101 lang=csharp
 *
 * [101] 对称二叉树
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
	public bool AreSymmetric(TreeNode r1,TreeNode r2)
	{
		if (r1.val != r2.val) return false;
		else if (r1.left == null && r1.right == null && r2.left == null && r2.right == null) return true;
		else if (r1.left == null && r2.right == null) return AreSymmetric(r1.right, r2.left);
		else if (r1.right == null && r2.left == null) return AreSymmetric(r1.left, r2.right);
		else if (r1.left == null || r1.right == null || r2.left == null || r2.right == null) return false;
		else return AreSymmetric(r1.left, r2.right) && AreSymmetric(r1.right, r2.left);
	}
	public bool IsSymmetric(TreeNode root)
	{
		if (root == null) return true;
		else if (root.left == null && root.right == null) return true;
		else if (root.left == null || root.right == null) return false;
		else return AreSymmetric(root.left, root.right);
	}
}
// @lc code=end