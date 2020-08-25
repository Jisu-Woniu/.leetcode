/*
 * @lc app=leetcode.cn id=219 lang=csharp
 *
 * [219] 存在重复元素 II
 */
using System.Collections.Generic;
// @lc code=start
public class Solution
{
	public bool ContainsNearbyDuplicate(int[] nums, int k)
	{
		if (nums.Length < 2 || k < 1)
			return false;
		int n = nums.Length;
		if (k > n - 1)
			k = n - 1;
		HashSet<int> visited = new HashSet<int>();
		for (int i = 0; i < k + 1; i++)
		{
			if (visited.Contains(nums[i]))
				return true;
			visited.Add(nums[i]);
		}
		for (int i = k + 1; i < n; i++)
		{
			visited.Remove(nums[i - k - 1]);
			if (visited.Contains(nums[i]))
				return true;
			visited.Add(nums[i]);
		}
		return false;
	}
}
// @lc code=end