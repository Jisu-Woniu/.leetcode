/*
 * @lc app=leetcode.cn id=300 lang=csharp
 *
 * [300] 最长上升子序列
 */
using System.Collections.Generic;
// @lc code=start
public class Solution
{
	List<int> tails = new List<int>();
	public int LengthOfLIS(int[] nums)
	{
		if (nums.Length <= 1)
			return nums.Length;
		foreach (int v in nums)
		{
			if (tails.Count==0||v > tails[tails.Count - 1])
				tails.Add(v);
			else
			{
				int index = tails.BinarySearch(v);
				if (index < 0)
					tails[~index] = v;
			}
		}
		return tails.Count;
	}
}
// @lc code=end