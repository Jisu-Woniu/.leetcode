/*
 * @lc app=leetcode.cn id=228 lang=csharp
 *
 * [228] 汇总区间
 */
using System.Collections.Generic;
// @lc code=start
struct Range
{
	public int L;
	public int R;
	public Range(int l, int r)
	{
		this.L = l;
		this.R = r;
	}
	public override string ToString() => L == R ? L.ToString() : $"{L}->{R}";
}

public class Solution
{
	public IList<string> SummaryRanges(int[] nums)
	{
		List<string> summary = new List<string>();
		if (nums.Length == 0)
		{
			return summary;
		}
		Range range = new Range(nums[0], nums[0]);
		for (int i = 1; i < nums.Length; i++)
		{
			if (nums[i] == range.R + 1)
			{
				range.R++;
			}
			else
			{
				summary.Add(range.ToString());
				range.L = range.R = nums[i];
			}
		}
		summary.Add(range.ToString());
		return summary;
	}
}
// @lc code=end

