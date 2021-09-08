/*
 * @lc app=leetcode.cn id=113 lang=csharp
 *
 * [113] 路径总和 II
 */
using System.Collections.Generic;
// using System.Linq;
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    List<IList<int>> result { get; } = new List<IList<int>>();
    public IList<IList<int>> PathSum(TreeNode root, int targetSum)
    {
        dfs(root, targetSum, new List<int>());
        return result;
    }
    void dfs(TreeNode root, int targetSum, List<int> current)
    {
        if (root == null)
            return;
        // path.Add(root);
        current.Add(root.val);
        if (root.left == null && root.right == null && targetSum == root.val)
            result.Add(current.ToArray());
        else
        {
            targetSum -= root.val;
            dfs(root.left, targetSum, current);
            dfs(root.right, targetSum, current);
        }
        current.RemoveAt(current.Count - 1);
    }
}
// @lc code=end
