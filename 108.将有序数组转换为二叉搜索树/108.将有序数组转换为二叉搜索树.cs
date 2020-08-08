/*
 * @lc app=leetcode.cn id=108 lang=csharp
 *
 * [108] 将有序数组转换为二叉搜索树
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
	public TreeNode SubArrayToBST(int[] nums, int l, int r)
	{
		if (l == r) return new TreeNode(nums[l]);
		else if (l > r) return null;
		int mid = (l + r) / 2;
		TreeNode root = new TreeNode(nums[mid]);
		root.left = SubArrayToBST(nums, l, mid - 1);
		root.right = SubArrayToBST(nums, mid + 1, r);
		return root;
	}
	public TreeNode SortedArrayToBST(int[] nums)
	{
		return SubArrayToBST(nums, 0, nums.Length - 1);
	}
}
// @lc code=end