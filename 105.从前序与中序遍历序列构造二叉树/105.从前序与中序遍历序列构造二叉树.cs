/*
 * @lc app=leetcode.cn id=105 lang=csharp
 *
 * [105] 从前序与中序遍历序列构造二叉树
 */
using System;
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
	TreeNode BuildTreeHelper(int[] preorder, int preLeft, int preRight, Dictionary<int, int> indexes, int inLeft, int inRight)
	{
		if (preLeft > preRight || inLeft > inRight)
			return null;
		int rootVal = preorder[preLeft];
		TreeNode root = new TreeNode(rootVal);
		int pIndex = indexes[rootVal];
		root.left = BuildTreeHelper(preorder, preLeft + 1, pIndex - inLeft + preLeft, indexes, inLeft, pIndex - 1);
		root.right = BuildTreeHelper(preorder, pIndex - inLeft + preLeft + 1, preRight, indexes, pIndex + 1, inRight);
		return root;
	}

	public TreeNode BuildTree(int[] preorder, int[] inorder)
	{
		int n = preorder.Length;
		if (n == 0) return null;
		int root = preorder[0];
		if (n == 1) return new TreeNode(root);
		Dictionary<int, int> indexes = new Dictionary<int, int>();
		for (int i = 0; i < n; i++)
		{
			indexes.Add(inorder[i], i);
		}
		return BuildTreeHelper(preorder, 0, n - 1, indexes, 0, n - 1);
	}
}
// @lc code=end 