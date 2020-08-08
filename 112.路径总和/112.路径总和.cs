/*
 * @lc app=leetcode.cn id=112 lang=csharp
 *
 * [112] 路径总和
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
/*public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}*/
public class Solution
{
	public bool HasPathSum(TreeNode root, int sum)
	{
		if (root == null) return false;
		else if (root.left == null && root.right == null) return root.val == sum;
		else 
		{
			sum -= root.val;
			return HasPathSum(root.left, sum) || HasPathSum(root.right, sum);
		}
	}
}
// @lc code=end