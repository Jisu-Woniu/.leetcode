/*
 * @lc app=leetcode.cn id=205 lang=csharp
 *
 * [205] 同构字符串
 */

// @lc code=start
using System.Collections.Generic;

public class Solution
{
	public bool IsomorphicTo(string s, string t)
	{
		Dictionary<char, char> charMap = new Dictionary<char, char>();
		for (int i = 0; i < s.Length; i++)
			if (!charMap.ContainsKey(s[i]))
				charMap.Add(s[i], t[i]);
			else if (charMap[s[i]] != t[i])
				return false;
		return true;
	}
	public bool IsIsomorphic(string s, string t)
	{
		return IsomorphicTo(s, t) && IsomorphicTo(t, s);
	}
}
// @lc code=end