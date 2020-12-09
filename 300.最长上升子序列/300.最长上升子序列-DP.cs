/*
 * @lc app=leetcode.cn id=300 lang=csharp
 *
 * [300] 最长上升子序列
 */

// @lc code=start
public class Solution
{
	public int LengthOfLIS(int[] nums)
	{
		if (nums.Length <= 1)
			return nums.Length;
		int[] LIS = new int[nums.Length];
		for (int i = 0; i < nums.Length; ++i)
		{
			LIS[i] = 1;
			for (int j = 0; j < i; ++j)
				if (nums[j] < nums[i] && LIS[j] >= LIS[i])
					LIS[i] = LIS[j] + 1;
		}
		int max = 0;
		foreach (int v in LIS)
			if (v > max)
				max = v;
		return max;
	}
}
// @lc code=end