/*
 * @lc app=leetcode.cn id=303 lang=csharp
 *
 * [303] 区域和检索 - 数组不可变
 */
using System;
// @lc code=start
public class NumArray
{
	int[] sums;

	public NumArray(int[] nums)
	{
		if (nums.Length < 1)
			return;
		sums = new int[nums.Length];
		sums[0] = nums[0];
		for (int i = 1; i < nums.Length; i++)
			sums[i] = nums[i] + sums[i - 1];
	}

	public int SumRange(int i, int j) => i == 0 ? sums[j] : sums[j] - sums[i - 1];
}
/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(i,j);
 */
// @lc code=end