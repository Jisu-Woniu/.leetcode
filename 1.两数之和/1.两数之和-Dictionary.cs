/*
 * @lc app=leetcode.cn id=1 lang=csharp
 *
 * [1] 两数之和
 */
using System.Collections.Generic;

// @lc code=start
public class Solution
{
	public int[] TwoSum(int[] nums, int target)
	{
		Dictionary<int, int> numSubPairs = new Dictionary<int, int>();
		for (int i = 0; i < nums.Length; i++)
		{
			if (numSubPairs.TryGetValue(target - nums[i], out int m)) return new int[] { m, i };
			else if (!numSubPairs.ContainsKey(nums[i])) numSubPairs.Add(nums[i], i);
		}
		return new int[] { };
	}
}
// @lc code=end