/*
 * @lc app=leetcode.cn id=189 lang=csharp
 *
 * [189] 旋转数组
 */
using System;
// @lc code=start
public class Solution
{
	public void Rotate(int[] nums, int k)
	{
		k %= nums.Length;
		Array.Reverse(nums);
		Array.Reverse(nums, 0, k);
		Array.Reverse(nums, k, nums.Length - k);
	}
}
// @lc code=end

