/*
 * @lc app=leetcode.cn id=205 lang=csharp
 *
 * [205] 同构字符串
 */
using System.Collections.Generic;
using System.Text;
// @lc code=start
public class Solution
{
	public string Isomorphic(string s)
	{
		Dictionary<char, char> charMap = new Dictionary<char, char>();
		StringBuilder builder = new StringBuilder();
		char ch = '0';
		foreach (char c in s)
		{
			if (!charMap.ContainsKey(c))
				charMap.Add(c, ch++);
			builder.Append(charMap[c]);
		}
		return builder.ToString();
	}
	public bool IsIsomorphic(string s, string t)
	{
		s = Isomorphic(s);
		t = Isomorphic(t);
		return string.Equals(t,s);
	}
}
// @lc code=end