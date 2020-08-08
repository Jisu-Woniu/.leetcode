/*
 * @lc app=leetcode.cn id=136 lang=csharp
 *
 * [136] 只出现一次的数字
 */
using System.Collections.Generic;
// @lc code=start
public class Solution
{
	public int SingleNumber(int[] nums)
	{
		if (nums.Length == 1)
			return nums[0];
		int res=0;
		foreach (int num in nums)
			res ^= num;
		return res;
	}
}
// @lc code=end

