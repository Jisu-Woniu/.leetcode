/*
 * @lc app=leetcode.cn id=169 lang=csharp
 *
 * [169] 多数元素
 */
using System.Collections.Generic;
// @lc code=start
public class Solution
{
	public int MajorityElement(int[] nums)
	{
		Dictionary<int, int> frequency = new Dictionary<int, int>();
		for (int i = 0; i < nums.Length; i++)
		{
			if (frequency.ContainsKey(nums[i])) ++frequency[nums[i]];
			else frequency.Add(nums[i], 1);
		}
		KeyValuePair<int, int> res = new KeyValuePair<int, int>(0, 0);
		foreach (KeyValuePair<int, int> p in frequency)
			if (res.Value > nums.Length / 2) return res.Key;
			else if (p.Value > res.Value)
				res = p;
		return res.Key;
	}
}
// @lc code=end