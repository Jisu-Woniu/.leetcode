/*
 * @lc app=leetcode.cn id=213 lang=csharp
 *
 * [213] 打家劫舍 II
 */
using System;
// @lc code=start
public class Solution
{
	public int Rob(int[] nums)
	{
		if (nums.Length == 1)
		{
			return nums[0];
		}
		return Math.Max(
			RobRange(nums, 0, nums.Length - 2),
			RobRange(nums, 1, nums.Length - 1)
			);
	}

	int RobRange(int[] nums, int l, int r)
	{
		int first = 0, second = nums[l];
		for (int i = l + 1; i <= r; i++)
		{
			int temp = second;
			second = Math.Max(first + nums[i], second);
			first = temp;
		}
		return second;
	}
}
// @lc code=end