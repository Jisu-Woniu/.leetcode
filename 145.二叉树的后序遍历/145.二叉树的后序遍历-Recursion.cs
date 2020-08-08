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
		List<int> res = new List<int>();
		if (root.left != null) res.AddRange(PostorderTraversal(root.left));
		if (root.right != null) res.AddRange(PostorderTraversal(root.right));
		res.Add(root.val);
		return res;
	}
}
// @lc code=end

