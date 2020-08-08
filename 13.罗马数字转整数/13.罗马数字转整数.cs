/*
 * @lc app=leetcode.cn id=13 lang=csharp
 *
 * [13] 罗马数字转整数
 */

// @lc code=start
//using System.Collections.Generic;
public class Solution
{
	public int RomanToInt(string s)
	{
		Dictionary<char, int> char2Int = new Dictionary<char, int>()
		{
			['I'] = 1,
			['V'] = 5,
			['X'] = 10,
			['L'] = 50,
			['C'] = 100,
			['D'] = 500,
			['M'] = 1_000
		};
		int res = 0;
		for (int i = 0; i < s.Length - 1; i++)
		{
			if (char2Int[s[i]] < char2Int[s[i + 1]])
				res -= char2Int[s[i]];
			else
				res += char2Int[s[i]];
		}
		res += char2Int[s[s.Length - 1]];
		return res;
	}
}
// @lc code=end