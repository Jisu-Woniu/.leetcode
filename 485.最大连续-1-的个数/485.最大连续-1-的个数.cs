/*
 * @lc app=leetcode.cn id=485 lang=csharp
 *
 * [485] 最大连续1的个数
 */
using System;
// @lc code=start
public class Solution
{
	public int FindMaxConsecutiveOnes(int[] nums)
	{
		int maxl = 0;
		int l = 0;
		for (int i = 0; i < nums.Length; i++)
		{
			if (nums[i] == 1)
				++l;
			else
			{
				maxl = Math.Max(maxl, l);
				l = 0;
			}
		}
		maxl = Math.Max(maxl, l);
		return maxl;
	}
}
// @lc code=end