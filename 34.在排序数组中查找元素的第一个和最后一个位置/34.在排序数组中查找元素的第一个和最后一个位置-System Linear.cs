/*
 * @lc app=leetcode.cn id=34 lang=csharp
 *
 * [34] 在排序数组中查找元素的第一个和最后一个位置
 */
using System;
// @lc code=start
public class Solution
{
	private int t;
	private bool Equal(int a) => a == t;
	public int[] SearchRange(int[] nums, int target)
	{
		t = target;
		return new int[2] { Array.FindIndex<int>(nums, Equal), Array.FindLastIndex<int>(nums, Equal) };
	}
}
// @lc code=end