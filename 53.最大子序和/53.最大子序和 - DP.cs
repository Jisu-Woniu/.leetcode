/*
 * @lc app=leetcode.cn id=53 lang=csharp
 *
 * [53] 最大子序和
 */

// @lc code=start
public class Solution
{
	public int MaxSubArray(int[] nums)
	{
		int preSum = 0;
		int maxSum = nums[0];
		foreach (int num in nums)
		{
			preSum = Math.Max(num, preSum + num);
			maxSum = Math.Max(preSum, maxSum);
		}
		return maxSum;
	}
}
// @lc code=end