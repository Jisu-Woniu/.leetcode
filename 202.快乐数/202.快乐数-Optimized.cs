/*
 * @lc app=leetcode.cn id=202 lang=csharp
 *
 * [202] 快乐数
 */
using System.Collections.Generic;
// @lc code=start
public class Solution
{
	HashSet<int> chked=new HashSet<int>();
	int Next(int num)
	{
		int next = 0;
		while (num != 0)
		{
			int t = num % 10;
			next += t * t;
			num /= 10;
		}
		return next;
	}
	public bool IsHappy(int n)
	{
		while (n >= 163) n = Next(n);//Next(999)=243;Next(9_999_999_999_999)=1053;Next(199)=163
		if (n == 1) return true;
		else if (chked.Contains(n)) return false;
		else
		{
			chked.Add(n);
			return IsHappy(Next(n));
		}
	}
}
// @lc code=end