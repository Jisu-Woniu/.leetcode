/*
 * @lc app=leetcode.cn id=220 lang=csharp
 *
 * [220] 存在重复元素 III
 */
using System.Collections.Generic;
// @lc code=start
public class Solution
{
	long w;
	public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
	{
		w = t + 1L;
		Dictionary<int, int> dict = new Dictionary<int, int>();
		for (int i = 0; i < nums.Length; i++)
		{
			if (i > k) dict.Remove(GetID(nums[i - k - 1]));
			int id = GetID(nums[i]);
			if (dict.ContainsKey(id)
				|| dict.ContainsKey(id - 1) && nums[i] * 1L - dict[id - 1] <= t
				|| dict.ContainsKey(id + 1) && dict[id + 1] - nums[i] * 1L <= t)
			{
				return true;
			}
			dict.Add(id, nums[i]);
		}
		return false;
	}
	int GetID(int n) => (int)(n >= 0 ? n / w : (n + 1) / w - 1);
}
// @lc code=end