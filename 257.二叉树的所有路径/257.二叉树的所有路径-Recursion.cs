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
	List<string> paths;
	string s;
	void DFS(TreeNode node)
	{
		string ts = s;
		s = s + "->" + node.val;
		if (node.left == null && node.right == null)
			paths.Add(s.ToString());
		if (node.left != null)
			DFS(node.left);
		if (node.right != null)
			DFS(node.right);
		s = ts;
	}
	public IList<string> BinaryTreePaths(TreeNode root)
	{
		paths = new List<string>();
		if (root == null)
			return paths;
		s = root.val.ToString();
		if (root.left == null && root.right == null)
		{
			paths.Add(s);
			return paths;
		}
		if (root.left != null)
			DFS(root.left);
		if (root.right != null)
			DFS(root.right);
		return paths;
	}
}
// @lc code=end