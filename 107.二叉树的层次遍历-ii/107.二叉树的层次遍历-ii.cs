/*
 * @lc app=leetcode.cn id=107 lang=csharp
 *
 * [107] 二叉树的层次遍历 II
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
	public IList<IList<int>> LevelOrderBottom(TreeNode root)
	{
		IList<IList<int>> r = new List<IList<int>>();
		if (root == null)
		{
			return r;
		}
		List<List<TreeNode>> fromRoot = new List<List<TreeNode>>();
		int i = 0;
		List<TreeNode> nextLevel = new List<TreeNode> { root };
		while (nextLevel.Count != 0)
		{
			fromRoot.Add(nextLevel);
			nextLevel = new List<TreeNode>();
			foreach (TreeNode treeNode in fromRoot[i])
			{
				if (treeNode.left != null)
					nextLevel.Add(treeNode.left);
				if (treeNode.right != null)
					nextLevel.Add(treeNode.right);
			}
			i++;
		}
		for (i = fromRoot.Count - 1; i >= 0; i--)
		{
			IList<int> thisLevel = new List<int>();
			foreach (TreeNode treeNode in fromRoot[i])
				thisLevel.Add(treeNode.val);
			r.Add(thisLevel);
		}
		return r;
	}
}
// @lc code=end