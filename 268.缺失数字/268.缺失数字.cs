/*
 * @lc app=leetcode.cn id=268 lang=csharp
 *
 * [268] 缺失数字
 */

// @lc code=start
public class Solution
{
	public int MissingNumber(int[] nums)
	{
		int n = nums.Length;
		int sum = n * (n + 1) / 2;
		foreach (int v in nums)
			sum -= v;
		return sum;
	}
}
// @lc code=end