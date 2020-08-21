/*
 * @lc app=leetcode.cn id=198 lang=csharp
 *
 * [198] 打家劫舍
 */
using System;
// @lc code=start
public class Solution
{
	int n;
	int[] search;
	int Search(int[] nums, int start)
	{
		if (start >= n) return 0;
		else if (start == n - 1) return nums[start];
		return Math.Max(
			nums[start] + search[start + 2],
			nums[start + 1] + search[start + 3]
			);
	}
	public int Rob(int[] nums)
	{
		n = nums.Length;
		search = new int[n + 2];
		for (int i = n + 1; i >= 0; i--)
			search[i] = Search(nums, i);
		return search[0];
	}
}
// @lc code=end