/*
 * @lc app=leetcode.cn id=342 lang=csharp
 *
 * [342] 4的幂
 */
using System;
// @lc code=start
public class Solution
{
	public bool IsPowerOfFour(int num)
	{
		int[] pow = new int[] { 1, 4, 0x10, 0x40, 0x100, 0x400, 0x1000, 0x4000, 0x10000,
			0x40000, 0x100000, 0x400000, 0x1000000, 0x4000000, 0x10000000, 0x40000000 };
		if (Array.BinarySearch<int>(pow, num) >= 0) return true;
		return false;
	}
}
// @lc code=end