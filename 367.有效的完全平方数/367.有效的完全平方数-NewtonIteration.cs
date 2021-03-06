/*
 * @lc app=leetcode.cn id=367 lang=csharp
 *
 * [367] 有效的完全平方数
 */
using System;
// @lc code=start
public class Solution
{
	public bool IsPerfectSquare(int num)
	{
		if (num == 1)
			return true;
		long x = num / 2;
		while (x * x > num)
			x = (x + num / x) / 2;
		return x * x == num;
	}
}
// @lc code=end