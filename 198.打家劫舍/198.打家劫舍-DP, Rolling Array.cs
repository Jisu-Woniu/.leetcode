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
		int first = nums[0], second = Math.Max(nums[0], nums[1]);
		for (int i = 2; i < length; i++)
		{
			int temp = second;
			second = Math.Max(first + nums[i], second);
			first = temp;
		}
		return second;
	}
}
// @lc code=end