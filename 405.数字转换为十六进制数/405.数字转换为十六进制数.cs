/*
 * @lc app=leetcode.cn id=405 lang=csharp
 *
 * [405] 数字转换为十六进制数
 */
using System;
// @lc code=start
public class Solution
{
	public string ToHex(int num)
	{
		if (num == 0)
			return "0";
		string s = "";
		int p = -1;
		if (num < 0) p = 8;
		while (num != 0)
		{
			if (p == 0) break;
			int t = num & 0xF;
			s = Convert.ToChar(t > 9 ? (t - 10 + 'a') : t + '0') + s;
			num >>= 4;
			--p;
		}
		return s;
	}
}
// @lc code=end