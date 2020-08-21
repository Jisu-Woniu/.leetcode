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
		int s = start % 4;
		if (start >= n) return 0;
		else if (start == n - 1) return nums[s];
		return Math.Max(
			nums[start] + search[(s + 2) % 4],
			nums[start + 1] + search[(s + 3) % 4]
			);
	}
	public int Rob(int[] nums)
	{
		n = nums.Length;
		search = new int[4];
		for (int i = n + 1; i >= 0; i--)
			search[i % 4] = Search(nums, i);
		return search[0];
	}
}
// @lc code=end