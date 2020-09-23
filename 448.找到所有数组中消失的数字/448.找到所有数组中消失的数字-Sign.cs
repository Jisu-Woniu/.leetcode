/*
 * @lc app=leetcode.cn id=448 lang=csharp
 *
 * [448] 找到所有数组中消失的数字
 */
using System;
using System.Collections.Generic;
// @lc code=start
public class Solution
{
	public IList<int> FindDisappearedNumbers(int[] nums)
	{
		foreach (int num in nums)
		{
			int i = Math.Abs(num) - 1;
			if (nums[i] > 0)
				nums[i] = -nums[i];
		}
		List<int> disappeared = new List<int>();
		for (int i = 0; i < nums.Length; ++i)
			if (nums[i] > 0)
				disappeared.Add(i + 1);
		return disappeared;
	}
}
// @lc code=end