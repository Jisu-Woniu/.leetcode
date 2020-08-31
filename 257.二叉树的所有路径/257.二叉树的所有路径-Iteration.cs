/*
 * @lc app=leetcode.cn id=257 lang=csharp
 *
 * [257] 二叉树的所有路径
 */
using System.Collections.Generic;
using System.Text;
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
	public IList<string> BinaryTreePaths(TreeNode root)
	{
		List<string> paths = new List<string>();
		if (root == null)
			return paths;
		Stack<TreeNode> node_stk = new Stack<TreeNode>();
		Stack<string> path_stk = new Stack<string>();
		node_stk.Push(root);
		path_stk.Push(root.val.ToString());
		TreeNode node;
		string path;
		while (node_stk.Count != 0)
		{
			node = node_stk.Pop();
			path = path_stk.Pop();
			if ((node.left == null) && (node.right == null))
				paths.Add(path);
			if (node.left != null)
			{
				node_stk.Push(node.left);
				path_stk.Push(path + "->" + node.left.val.ToString());
			}
			if (node.right != null)
			{
				node_stk.Push(node.right);
				path_stk.Push(path + "->" + node.right.val.ToString());
			}
		}
		return paths;
	}
}
// @lc code=end