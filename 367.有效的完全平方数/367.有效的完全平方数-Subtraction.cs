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
		int a = 1;
		while (num > 0)
		{
			num -= a;
			a += 2;
		}
		return num == 0;
	}
}
// @lc code=end