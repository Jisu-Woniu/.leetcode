/*
 * @lc app=leetcode.cn id=198 lang=csharp
 *
 * [198] 打家劫舍
 */
using System;
// @lc code=start
public class Solution
{
	public int Rob(int[] nums)
	{
		if (nums == null || nums.Length == 0) return 0;
		int length = nums.Length;
		if (length == 1) return nums[0];
		int[] dp = new int[length];
		dp[0] = nums[0];
		dp[1] = Math.Max(nums[0], nums[1]);
		for (int i = 2; i < length; i++)
			dp[i] = Math.Max(dp[i - 2] + nums[i], dp[i - 1]);
		return dp[length - 1];
	}
}
// @lc code=end