/*
 * @lc app=leetcode.cn id=217 lang=csharp
 *
 * [217] 存在重复元素
 */
using System;
// @lc code=start
public class Solution
{
	public bool ContainsDuplicate(int[] nums)
	{
		if (nums.Length < 2)
			return false;
		Array.Sort<int>(nums);
		for (int i = 0; i < nums.Length - 1; i++)
			if (nums[i] == nums[i + 1])
				return true;
		return false;
	}
}
// @lc code=end